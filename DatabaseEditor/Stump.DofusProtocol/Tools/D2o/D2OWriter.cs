using Stump.Core.IO;
using Stump.DofusProtocol.Tools.D2o;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2o
{
	public class D2OWriter : IDisposable
	{
		private const int NullIdentifier = -1431655766;

		private readonly object m_writingSync = new object();

		private Dictionary<Type, int> m_allocatedClassId = new Dictionary<Type, int>();

		private Dictionary<int, D2OClassDefinition> m_classes;

		private Dictionary<int, int> m_indexTable;

		private bool m_needToBeSync;

		private Dictionary<int, object> m_objects = new Dictionary<int, object>();

		private BigEndianWriter m_writer;

		private bool m_writing;

		private int m_nextIndex;

		public string BakFilename
		{
			get;
			set;
		}

		public string Filename
		{
			get;
			set;
		}

		public D2OWriter(string filename, bool readDefinitionsOnly = false)
		{
			Filename = filename;
			if (!File.Exists(filename))
			{
				CreateWrite(filename);
			}
			else
			{
				OpenWrite(readDefinitionsOnly);
			}
		}

		public void Dispose()
		{
			if (m_writing)
			{
				EndWriting();
			}
		}

		public static void CreateEmptyFile(string path)
		{
			if (File.Exists(path))
			{
				throw new Exception("File already exists, delete before overwrite");
			}
			BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(path));
			binaryWriter.Write("D2O");
			binaryWriter.Write((int)binaryWriter.BaseStream.Position + 4);
			binaryWriter.Write(0);
			binaryWriter.Write(0);
			binaryWriter.Flush();
			binaryWriter.Close();
		}

		private void CreateWrite(string filename)
		{
			m_indexTable = new Dictionary<int, int>();
			m_classes = new Dictionary<int, D2OClassDefinition>();
			m_objects = new Dictionary<int, object>();
			m_allocatedClassId = new Dictionary<Type, int>();
		}

		private void OpenWrite(bool readDefinitionsOnly = false)
		{
			ResetMembersByReading(readDefinitionsOnly);
		}

		private void ResetMembersByReading(bool readDefinitionsOnly = false)
		{
			D2OReader d2OReader = new D2OReader(File.OpenRead(Filename));
			m_indexTable = (readDefinitionsOnly ? new Dictionary<int, int>() : d2OReader.Indexes);
			m_classes = d2OReader.Classes;
			m_allocatedClassId = m_classes.ToDictionary((KeyValuePair<int, D2OClassDefinition> entry) => entry.Value.ClassType, (KeyValuePair<int, D2OClassDefinition> entry) => entry.Key);
			m_objects = (readDefinitionsOnly ? new Dictionary<int, object>() : d2OReader.ReadObjects());
			d2OReader.Close();
		}

		public void StartWriting(bool backupFile = true)
		{
			if (File.Exists(Filename))
			{
				if (backupFile)
				{
					BakFilename = Filename + ".bak";
					File.Copy(Filename, BakFilename, overwrite: true);
				}
				File.Delete(Filename);
			}
			m_writer = new BigEndianWriter(File.Create(Filename));
			m_writing = true;
			lock (m_writingSync)
			{
				if (m_needToBeSync)
				{
					ResetMembersByReading();
				}
			}
		}

		public void EndWriting()
		{
			lock (m_writingSync)
			{
				m_writer.Seek(0, SeekOrigin.Begin);
				m_writing = false;
				m_needToBeSync = false;
				WriteHeader();
				foreach (KeyValuePair<int, object> @object in m_objects)
				{
					if (!m_indexTable.ContainsKey(@object.Key))
					{
						m_indexTable.Add(@object.Key, (int)m_writer.BaseStream.Position);
					}
					else
					{
						m_indexTable[@object.Key] = (int)m_writer.BaseStream.Position;
					}
					WriteObject(m_writer, @object.Value, @object.Value.GetType());
				}
				WriteIndexTable();
				WriteClassesDefinition();
				WriteSearchTable();
				m_writer.Dispose();
			}
		}

		private void WriteHeader()
		{
			m_writer.WriteUTFBytes("D2O");
			m_writer.WriteInt(0);
		}

		private void WriteIndexTable()
		{
			int num = (int)m_writer.BaseStream.Position;
			m_writer.Seek(3, SeekOrigin.Begin);
			m_writer.WriteInt(num);
			m_writer.Seek(num, SeekOrigin.Begin);
			m_writer.WriteInt(m_indexTable.Count * 8);
			foreach (KeyValuePair<int, int> item in m_indexTable)
			{
				m_writer.WriteInt(item.Key);
				m_writer.WriteInt(item.Value);
			}
		}

		private void WriteClassesDefinition()
		{
			m_writer.WriteInt(m_classes.Count);
			foreach (D2OClassDefinition value in m_classes.Values)
			{
				value.Offset = (int)m_writer.BaseStream.Position;
				m_writer.WriteInt(value.Id);
				m_writer.WriteUTF(value.Name);
				m_writer.WriteUTF(value.PackageName);
				m_writer.WriteInt(value.Fields.Count);
				foreach (D2OFieldDefinition value2 in value.Fields.Values)
				{
					value2.Offset = (int)m_writer.BaseStream.Position;
					m_writer.WriteUTF(value2.Name);
					m_writer.WriteInt((int)value2.TypeId);
					Tuple<D2OFieldType, Type>[] vectorTypes = value2.VectorTypes;
					foreach (Tuple<D2OFieldType, Type> tuple in vectorTypes)
					{
						m_writer.WriteUTF(ConvertNETTypeToAS3(tuple.Item2));
						m_writer.WriteInt((int)tuple.Item1);
					}
				}
			}
		}

		private void WriteSearchTable()
		{
			int num = (int)m_writer.BaseStream.Position;
			m_writer.WriteInt(0);
			foreach (D2OClassDefinition value in m_classes.Values)
			{
				foreach (KeyValuePair<string, D2OFieldDefinition> field in value.Fields)
				{
					m_writer.WriteUTF(field.Value.Name);
					m_writer.WriteInt((int)field.Value.Offset);
					m_writer.WriteInt((int)field.Value.TypeId);
					m_writer.WriteInt(value.Fields.Count);
				}
			}
			int num2 = (int)m_writer.BaseStream.Position;
			m_writer.Seek(num, SeekOrigin.Begin);
			m_writer.WriteInt(num2 - num - 4);
		}

		public void Write(object obj, Type type, int index)
		{
			if (!m_writing)
			{
				StartWriting();
			}
			lock (m_writingSync)
			{
				m_needToBeSync = true;
				if (!IsClassDeclared(type))
				{
					DefineClassDefinition(type);
				}
				if (m_objects.ContainsKey(index))
				{
					m_objects[index] = obj;
				}
				else
				{
					m_objects.Add(index, obj);
				}
			}
		}

		public void Write(object obj, Type type)
		{
			Write(obj, type, (m_objects.Count <= 0) ? 1 : (m_objects.Keys.Max() + 1));
		}

		public void Write(object obj, int index)
		{
			Write(obj, obj.GetType(), index);
		}

		public void Write(object obj)
		{
			Write(obj, obj.GetType());
		}

		public void Write<T>(T obj)
		{
			Write(obj, typeof(T));
		}

		public void Write<T>(T obj, int index)
		{
			Write(obj, typeof(T), index);
		}

		public void Delete(int index)
		{
			lock (m_writingSync)
			{
				if (m_objects.ContainsKey(index))
				{
					m_objects.Remove(index);
				}
			}
		}

		private bool IsClassDeclared(Type classType)
		{
			return m_allocatedClassId.ContainsKey(classType);
		}

		private int AllocateClassId(Type classType)
		{
			int num = (m_allocatedClassId.Count <= 0) ? 1 : (m_allocatedClassId.Values.Max() + 1);
			AllocateClassId(classType, num);
			return num;
		}

		private void AllocateClassId(Type classType, int classId)
		{
			m_allocatedClassId.Add(classType, classId);
		}

		private void DefineClassDefinition(Type classType)
		{
			if (m_classes.Count((KeyValuePair<int, D2OClassDefinition> entry) => entry.Value.ClassType == classType) > 0)
			{
				return;
			}
			if (!m_allocatedClassId.ContainsKey(classType))
			{
				AllocateClassId(classType);
			}
			object[] customAttributes = classType.GetCustomAttributes(typeof(D2OClassAttribute), inherit: false);
			if (customAttributes.Length != 1)
			{
				throw new Exception("The given class has no D2OClassAttribute attribute and cannot be wrote");
			}
			string packageName = ((D2OClassAttribute)customAttributes[0]).PackageName;
			string classname = (!string.IsNullOrEmpty(((D2OClassAttribute)customAttributes[0]).Name)) ? ((D2OClassAttribute)customAttributes[0]).Name : classType.Name;
			List<D2OFieldDefinition> list = new List<D2OFieldDefinition>();
			FieldInfo[] fields = classType.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (!fieldInfo.GetCustomAttributes(typeof(D2OIgnore), inherit: false).Any() && !fieldInfo.IsStatic && !fieldInfo.IsPrivate && !fieldInfo.IsInitOnly)
				{
					D2OFieldAttribute d2OFieldAttribute = (D2OFieldAttribute)fieldInfo.GetCustomAttributes(typeof(D2OFieldAttribute), inherit: false).SingleOrDefault();
					D2OFieldType idByType = GetIdByType(fieldInfo);
					Tuple<D2OFieldType, Type>[] vectorTypes = GetVectorTypes(fieldInfo.FieldType);
					string name = (d2OFieldAttribute != null) ? d2OFieldAttribute.FieldName : fieldInfo.Name;
					list.Add(new D2OFieldDefinition(name, idByType, fieldInfo, -1L, vectorTypes));
				}
			}
			PropertyInfo[] properties = classType.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (!propertyInfo.GetCustomAttributes(typeof(D2OIgnore), inherit: false).Any() && propertyInfo.CanWrite)
				{
					D2OFieldAttribute d2OFieldAttribute2 = (D2OFieldAttribute)propertyInfo.GetCustomAttributes(typeof(D2OFieldAttribute), inherit: false).SingleOrDefault();
					D2OFieldType idByType2 = GetIdByType(propertyInfo);
					Tuple<D2OFieldType, Type>[] vectorTypes2 = GetVectorTypes(propertyInfo.PropertyType);
					string fieldName = (d2OFieldAttribute2 != null) ? d2OFieldAttribute2.FieldName : propertyInfo.Name;
					if (!list.Any((D2OFieldDefinition x) => x.Name == fieldName))
					{
						list.Add(new D2OFieldDefinition(fieldName, idByType2, propertyInfo, -1L, vectorTypes2));
					}
				}
			}
			m_classes.Add(m_allocatedClassId[classType], new D2OClassDefinition(m_allocatedClassId[classType], classname, packageName, classType, list, -1L));
			DefineAllocatedTypes();
		}

		private void DefineAllocatedTypes()
		{
			KeyValuePair<Type, int>[] array = (from entry in m_allocatedClassId
											   where !m_classes.ContainsKey(entry.Value)
											   select entry).ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				KeyValuePair<Type, int> keyValuePair = array[i];
				DefineClassDefinition(keyValuePair.Key);
			}
		}

		private D2OFieldType GetIdByType(FieldInfo field)
		{
			Type fieldType = field.FieldType;
			if (field.GetCustomAttribute<I18NFieldAttribute>() != null)
			{
				return D2OFieldType.I18N;
			}
			return GetIdByType(fieldType);
		}

		private D2OFieldType GetIdByType(PropertyInfo property)
		{
			Type propertyType = property.PropertyType;
			if (property.GetCustomAttribute<I18NFieldAttribute>() != null)
			{
				return D2OFieldType.I18N;
			}
			return GetIdByType(propertyType);
		}

		private D2OFieldType GetIdByType(Type fieldType)
		{
			if (fieldType == typeof(int))
			{
				return D2OFieldType.Int;
			}
			if (fieldType == typeof(bool))
			{
				return D2OFieldType.Bool;
			}
			if (fieldType == typeof(string))
			{
				return D2OFieldType.String;
			}
			if (fieldType == typeof(double) || fieldType == typeof(float))
			{
				return D2OFieldType.Double;
			}
			if (fieldType == typeof(uint))
			{
				return D2OFieldType.UInt;
			}
			if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
			{
				return D2OFieldType.List;
			}
			if (!m_allocatedClassId.ContainsKey(fieldType))
			{
				int num = AllocateClassId(fieldType);
			}
			return (D2OFieldType)m_allocatedClassId[fieldType];
		}

		private Tuple<D2OFieldType, Type>[] GetVectorTypes(Type vectorType)
		{
			List<Tuple<D2OFieldType, Type>> list = new List<Tuple<D2OFieldType, Type>>();
			if (vectorType.IsGenericType)
			{
				Type type = vectorType;
				Type[] genericArguments = type.GetGenericArguments();
				while (genericArguments.Length != 0)
				{
					list.Add(Tuple.Create(GetIdByType(genericArguments[0]), type));
					type = genericArguments[0];
					genericArguments = type.GetGenericArguments();
				}
			}
			return list.ToArray();
		}

		private string ConvertNETTypeToAS3(Type type)
		{
			switch (type.Name)
			{
				case "Int32":
				case "Int16":
				case "UInt16":
					return "int";
				case "UInt32":
					return "uint";
				case "Int64":
				case "UInt64":
				case "Single":
				case "Double":
					return "Number";
				case "String":
					return "String";
				default:
					{
						if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
						{
							return "Vector.<" + ConvertNETTypeToAS3(type.GetGenericArguments()[0]) + ">";
						}
						D2OClassDefinition d2OClassDefinition = m_classes.Values.FirstOrDefault((D2OClassDefinition x) => x.ClassType == type);
						if (d2OClassDefinition == null)
						{
							throw new Exception($"Cannot found AS3 type associated to {type}");
						}
						return d2OClassDefinition.PackageName + "::" + d2OClassDefinition.Name;
					}
			}
		}

		private void WriteObject(IDataWriter writer, object obj, Type type)
		{
			if (!m_allocatedClassId.ContainsKey(obj.GetType()))
			{
				DefineClassDefinition(obj.GetType());
			}
			D2OClassDefinition d2OClassDefinition = m_classes[m_allocatedClassId[type]];
			writer.WriteInt(d2OClassDefinition.Id);
			foreach (KeyValuePair<string, D2OFieldDefinition> field in d2OClassDefinition.Fields)
			{
				object value = field.Value.GetValue(obj);
				WriteField(writer, field.Value.TypeId, field.Value, value);
			}
		}

		private void WriteField(IDataWriter writer, D2OFieldType fieldType, D2OFieldDefinition field, dynamic obj, int vectorDimension = 0)
		{
			switch (fieldType)
			{
				case D2OFieldType.Int:
					WriteFieldInt(writer, (int)obj);
					break;
				case D2OFieldType.Bool:
					WriteFieldBool(writer, obj);
					break;
				case D2OFieldType.String:
					WriteFieldUTF(writer, obj);
					break;
				case D2OFieldType.Double:
					WriteFieldDouble(writer, obj);
					break;
				case D2OFieldType.I18N:
					WriteFieldI18n(writer, (int)obj);
					break;
				case D2OFieldType.UInt:
					WriteFieldUInt(writer, (uint)obj);
					break;
				case D2OFieldType.List:
					this.WriteFieldVector(writer, field, obj, vectorDimension);
					break;
				default:
					this.WriteFieldObject(writer, obj);
					break;
			}
		}

		private void WriteFieldVector(IDataWriter writer, D2OFieldDefinition field, IList list, int vectorDimension)
		{
			if (list == null)
			{
				writer.WriteInt(0);
				return;
			}
			writer.WriteInt(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				WriteField(writer, field.VectorTypes[vectorDimension].Item1, field, list[i], vectorDimension + 1);
			}
		}

		private void WriteFieldObject(IDataWriter writer, object obj)
		{
			if (obj == null)
			{
				writer.WriteInt(-1431655766);
				return;
			}
			if (!m_allocatedClassId.ContainsKey(obj.GetType()))
			{
				DefineClassDefinition(obj.GetType());
			}
			WriteObject(writer, obj, obj.GetType());
		}

		private static void WriteFieldInt(IDataWriter writer, int value)
		{
			writer.WriteInt(value);
		}

		private static void WriteFieldUInt(IDataWriter writer, uint value)
		{
			writer.WriteUInt(value);
		}

		private static void WriteFieldBool(IDataWriter writer, bool value)
		{
			writer.WriteBoolean(value);
		}

		private static void WriteFieldUTF(IDataWriter writer, string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			writer.WriteUTF(value);
		}

		private static void WriteFieldDouble(IDataWriter writer, double value)
		{
			writer.WriteDouble(value);
		}

		private static void WriteFieldI18n(IDataWriter writer, int value)
		{
			writer.WriteInt(value);
		}
	}
}
