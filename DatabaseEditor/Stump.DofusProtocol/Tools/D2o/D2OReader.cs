using Stump.Core.IO;
using Stump.Core.Reflection;
using Stump.DofusProtocol.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2o
{
	public class D2OReader
	{
		private const int NullIdentifier = -1431655766;

		public static List<Assembly> ClassesContainers = new List<Assembly>
		{
			typeof(Breed).Assembly
		};

		private static readonly Dictionary<Type, Func<object[], object>> objectCreators = new Dictionary<Type, Func<object[], object>>();

		private readonly string m_filePath;

		private int m_classcount;

		private Dictionary<int, D2OClassDefinition> m_classes;

		private int m_headeroffset;

		private Dictionary<int, int> m_indextable = new Dictionary<int, int>();

		private Dictionary<string, D2OSearchEntry> m_searchEntries = new Dictionary<string, D2OSearchEntry>();

		private int m_indextablelen;

		private IDataReader m_reader;

		private int m_contentOffset = 0;

		public string FilePath => m_filePath;

		public string FileName => Path.GetFileNameWithoutExtension(FilePath);

		public int IndexCount => m_indextable.Count;

		public int IndexTableOffset => m_headeroffset;

		public Dictionary<int, D2OClassDefinition> Classes => m_classes;

		public Dictionary<int, int> Indexes => m_indextable;

		public D2OReader(string filePath)
			: this(new FastBigEndianReader(File.ReadAllBytes(filePath)))
		{
			m_filePath = filePath;
		}

		public D2OReader(Stream stream)
		{
			m_reader = new BigEndianReader(stream);
			Initialize();
		}

		public D2OReader(IDataReader reader)
		{
			m_reader = reader;
			Initialize();
		}

		private void Initialize()
		{
			lock (m_reader)
			{
				ReadHeader();
				ReadIndexTable();
				ReadClassesTable();
				ReadSearchTable();
			}
		}

		private void ReadHeader()
		{
			string a = m_reader.ReadUTFBytes(3);
			if (a != "D2O")
			{
				m_reader.Seek(0, SeekOrigin.Begin);
				try
				{
					a = m_reader.ReadUTF();
				}
				catch
				{
					throw new Exception("Header doesn't equal the string 'D2O' OR 'AKSF' : Corrupted file");
				}
				if (!(a == "AKSF"))
				{
					throw new Exception("Header doesn't equal the string 'D2O' OR 'AKSF' : Corrupted file");
				}
				short num = m_reader.ReadShort();
				int offset = m_reader.ReadInt();
				m_reader.Seek(offset, SeekOrigin.Current);
				m_contentOffset = (int)m_reader.Position;
				a = m_reader.ReadUTFBytes(3);
				if (a != "D2O")
				{
					throw new Exception("Header doesn't equal the string 'D2O' : Corrupted file (signed file)");
				}
			}
		}

		private void ReadIndexTable(bool isD2OS = false)
		{
			m_headeroffset = m_reader.ReadInt();
			m_reader.Seek(m_contentOffset + m_headeroffset, SeekOrigin.Begin);
			m_indextablelen = m_reader.ReadInt();
			m_indextable = new Dictionary<int, int>(m_indextablelen / 8);
			for (int i = 0; i < m_indextablelen; i += 8)
			{
				m_indextable.Add(m_reader.ReadInt(), m_reader.ReadInt());
			}
		}

		private void ReadClassesTable()
		{
			Dictionary<D2OFieldDefinition, List<Tuple<D2OFieldType, string>>> dictionary = new Dictionary<D2OFieldDefinition, List<Tuple<D2OFieldType, string>>>();
			m_classcount = m_reader.ReadInt();
			m_classes = new Dictionary<int, D2OClassDefinition>(m_classcount);
			for (int i = 0; i < m_classcount; i++)
			{
				int num = m_reader.ReadInt();
				string text = m_reader.ReadUTF();
				string packagename = m_reader.ReadUTF();
				Type type = FindType(text);
				int num2 = m_reader.ReadInt();
				List<D2OFieldDefinition> list = new List<D2OFieldDefinition>(num2);
				for (int j = 0; j < num2; j++)
				{
					string text2 = m_reader.ReadUTF();
					D2OFieldType d2OFieldType = (D2OFieldType)m_reader.ReadInt();
					FieldInfo field = type.GetField(text2);
					if (field == null)
					{
						throw new Exception($"Missing field '{text2}' ({d2OFieldType}) in class '{type.Name}'");
					}
					D2OFieldDefinition d2OFieldDefinition = new D2OFieldDefinition(text2, d2OFieldType, field, m_reader.Position);
					List<Tuple<D2OFieldType, object>> list2 = new List<Tuple<D2OFieldType, object>>();
					if (d2OFieldType == D2OFieldType.List)
					{
						D2OFieldType d2OFieldType2;
						do
						{
							string item = m_reader.ReadUTF();
							d2OFieldType2 = (D2OFieldType)m_reader.ReadInt();
							if (!dictionary.ContainsKey(d2OFieldDefinition))
							{
								dictionary.Add(d2OFieldDefinition, new List<Tuple<D2OFieldType, string>>());
							}
							dictionary[d2OFieldDefinition].Add(Tuple.Create(d2OFieldType2, item));
						}
						while (d2OFieldType2 == D2OFieldType.List);
					}
					list.Add(d2OFieldDefinition);
				}
				m_classes.Add(num, new D2OClassDefinition(num, text, packagename, type, list, m_reader.Position));
			}
			foreach (KeyValuePair<D2OFieldDefinition, List<Tuple<D2OFieldType, string>>> item2 in dictionary)
			{
				item2.Key.VectorTypes = (from tuple in item2.Value
										 select Tuple.Create(tuple.Item1, FindNETType(tuple.Item2))).ToArray();
			}
		}

		private void ReadSearchTable()
		{
			int num = m_reader.ReadInt();
			int num2 = (int)(m_reader.Position + 4 + num);
			while (num > 0)
			{
				long bytesAvailable = m_reader.BytesAvailable;
				D2OSearchEntry d2OSearchEntry = new D2OSearchEntry(m_reader.ReadUTF(), m_reader.ReadInt() + num2, (D2OFieldType)m_reader.ReadInt(), m_reader.ReadInt());
				if (!m_searchEntries.ContainsKey(d2OSearchEntry.FieldName))
				{
					m_searchEntries.Add(d2OSearchEntry.FieldName, d2OSearchEntry);
				}
				num -= (int)(bytesAvailable - m_reader.BytesAvailable);
			}
		}

		private Dictionary<int, object> BuildSortIndex(string field)
		{
			if (!m_searchEntries.TryGetValue(field, out D2OSearchEntry value))
			{
				throw new Exception($"{field} is not a search field");
			}
			Dictionary<int, object> dictionary = new Dictionary<int, object>();
			m_reader.Seek(value.FieldIndex, SeekOrigin.Begin);
			for (int i = 0; i < value.FieldCount; i++)
			{
				object value2 = ReadField(m_reader, value.FieldType);
				int num = m_reader.ReadInt() / 4;
				for (int j = 0; j < num; j++)
				{
					dictionary.Add(m_reader.ReadInt(), value2);
				}
			}
			return dictionary;
		}

		private Type FindNETType(string typeName)
		{
			switch (typeName)
			{
				case "int":
					return typeof(int);
				case "uint":
					return typeof(uint);
				case "Number":
					return typeof(double);
				case "String":
					return typeof(string);
				default:
					{
						if (typeName.StartsWith("Vector.<"))
						{
							return typeof(List<>).MakeGenericType(FindNETType(typeName.Remove(typeName.Length - 1, 1).Remove(0, "Vector.<".Length)));
						}
						D2OClassDefinition d2OClassDefinition = m_classes.Values.FirstOrDefault((D2OClassDefinition x) => x.PackageName + "::" + x.Name == typeName);
						if (d2OClassDefinition == null)
						{
							throw new Exception($"Cannot found .NET type associated to {typeName}");
						}
						return d2OClassDefinition.ClassType;
					}
			}
		}

		private static Type FindType(string className)
		{
			IEnumerable<Type> source = from asm in ClassesContainers
									   let types = asm.GetTypes()
									   from type in types
									   where type.Name.Equals(className, StringComparison.InvariantCulture) && type.HasInterface(typeof(IDataObject))
									   select type;
			return source.FirstOrDefault();
		}

		private bool IsTypeDefined(Type type)
		{
			return m_classes.Count((KeyValuePair<int, D2OClassDefinition> entry) => entry.Value.ClassType == type) > 0;
		}

		public Dictionary<int, T> ReadObjects<T>(bool allownulled = false) where T : class
		{
			if (!IsTypeDefined(typeof(T)))
			{
				throw new Exception("The file doesn't contain this class");
			}
			Dictionary<int, T> dictionary = new Dictionary<int, T>(m_indextable.Count);
			using (IDataReader dataReader = CloneReader())
			{
				foreach (KeyValuePair<int, int> item in m_indextable)
				{
					dataReader.Seek(item.Value, SeekOrigin.Begin);
					int key = dataReader.ReadInt();
					if (m_classes[key].ClassType == typeof(T) || m_classes[key].ClassType.IsSubclassOf(typeof(T)))
					{
						try
						{
							dictionary.Add(item.Key, BuildObject(m_classes[key], dataReader) as T);
						}
						catch
						{
							if (!allownulled)
							{
								throw;
							}
							dictionary.Add(item.Key, null);
						}
					}
				}
			}
			return dictionary;
		}

		public Dictionary<int, object> ReadObjects(bool allownulled = false, bool cloneReader = false)
		{
			Dictionary<int, object> dictionary = new Dictionary<int, object>(m_indextable.Count);
			IDataReader dataReader = cloneReader ? CloneReader() : m_reader;
			foreach (KeyValuePair<int, int> item in m_indextable)
			{
				dataReader.Seek(item.Value + m_contentOffset, SeekOrigin.Begin);
				try
				{
					dictionary.Add(item.Key, ReadObject(item.Key, dataReader));
				}
				catch
				{
					if (!allownulled)
					{
						throw;
					}
					dictionary.Add(item.Key, null);
				}
			}
			if (cloneReader)
			{
				dataReader.Dispose();
			}
			return dictionary;
		}

		public IEnumerable<object> EnumerateObjects(bool cloneReader = false)
		{
			IDataReader reader = cloneReader ? CloneReader() : m_reader;
			foreach (KeyValuePair<int, int> index in m_indextable)
			{
				reader.Seek(index.Value + m_contentOffset, SeekOrigin.Begin);
				yield return ReadObject(index.Key, reader);
			}
			if (cloneReader)
			{
				reader.Dispose();
			}
		}

		public object ReadObject(int index, bool cloneReader = false)
		{
			if (cloneReader)
			{
				using (IDataReader reader = CloneReader())
				{
					return ReadObject(index, reader);
				}
			}
			lock (m_reader)
			{
				return ReadObject(index, m_reader);
			}
		}

		private object ReadObject(int index, IDataReader reader)
		{
			int num = m_indextable[index];
			reader.Seek(num + m_contentOffset, SeekOrigin.Begin);
			int key = reader.ReadInt();
			return BuildObject(m_classes[key], reader);
		}

		private object BuildObject(D2OClassDefinition classDefinition, IDataReader reader)
		{
			if (!objectCreators.ContainsKey(classDefinition.ClassType))
			{
				Func<object[], object> value = CreateObjectBuilder(classDefinition.ClassType, (from entry in classDefinition.Fields
																							   select entry.Value.FieldInfo).ToArray());
				objectCreators.Add(classDefinition.ClassType, value);
			}
			List<object> list = new List<object>();
			foreach (D2OFieldDefinition value2 in classDefinition.Fields.Values)
			{
				object obj = ReadField(reader, value2, value2.TypeId);
				if (obj == null || value2.FieldType.IsInstanceOfType(obj))
				{
					list.Add(obj);
				}
				else
				{
					if (!(obj is IConvertible) || !(value2.FieldType.GetInterface("IConvertible") != null))
					{
						throw new Exception($"Field '{classDefinition.Name}.{value2.Name}' with value {obj} is not of type '{obj.GetType()}'");
					}
					try
					{
						if (obj is int && (int)obj < 0 && value2.FieldType == typeof(uint))
						{
							list.Add((uint)(int)obj);
						}
						else
						{
							list.Add(Convert.ChangeType(obj, value2.FieldType));
						}
					}
					catch
					{
						throw new Exception($"Field '{classDefinition.Name}.{value2.Name}' with value {obj} is not of type '{obj.GetType()}'");
					}
				}
			}
			return objectCreators[classDefinition.ClassType](list.ToArray());
		}

		public T ReadObject<T>(int index, bool cloneReader = false) where T : class
		{
			if (cloneReader)
			{
				using (IDataReader reader = CloneReader())
				{
					return ReadObject<T>(index, reader);
				}
			}
			return ReadObject<T>(index, m_reader);
		}

		private T ReadObject<T>(int index, IDataReader reader) where T : class
		{
			if (!IsTypeDefined(typeof(T)))
			{
				throw new Exception("The file doesn't contain this class");
			}
			int value = 0;
			if (!m_indextable.TryGetValue(index, out value))
			{
				throw new Exception($"Can't find Index {index} in {FileName}");
			}
			reader.Seek(value + m_contentOffset, SeekOrigin.Begin);
			int key = reader.ReadInt();
			if (m_classes[key].ClassType != typeof(T) && !m_classes[key].ClassType.IsSubclassOf(typeof(T)))
			{
				throw new Exception(string.Format("Wrong type, try to read object with {1} instead of {0}", typeof(T).Name, m_classes[key].ClassType.Name));
			}
			return BuildObject(m_classes[key], reader) as T;
		}

		public int FindFreeId()
		{
			return m_indextable.Keys.Max() + 1;
		}

		public Dictionary<int, D2OClassDefinition> GetObjectsClasses()
		{
			return m_indextable.ToDictionary((KeyValuePair<int, int> index) => index.Key, (KeyValuePair<int, int> index) => GetObjectClass(index.Key));
		}

		public D2OClassDefinition GetObjectClass(int index)
		{
			lock (m_reader)
			{
				int num = m_indextable[index];
				m_reader.Seek(num + m_contentOffset, SeekOrigin.Begin);
				int key = m_reader.ReadInt();
				return m_classes[key];
			}
		}

		private object ReadField(IDataReader reader, D2OFieldDefinition field, D2OFieldType typeId, int vectorDimension = 0)
		{
			switch (typeId)
			{
				case D2OFieldType.Int:
					return ReadFieldInt(reader);
				case D2OFieldType.Bool:
					return ReadFieldBool(reader);
				case D2OFieldType.String:
					return ReadFieldUTF(reader);
				case D2OFieldType.Double:
					return ReadFieldDouble(reader);
				case D2OFieldType.I18N:
					return ReadFieldI18n(reader);
				case D2OFieldType.UInt:
					return ReadFieldUInt(reader);
				case D2OFieldType.List:
					return ReadFieldVector(reader, field, vectorDimension);
				default:
					return ReadFieldObject(reader);
			}
		}

		private object ReadField(IDataReader reader, D2OFieldType typeId)
		{
			switch (typeId)
			{
				case D2OFieldType.Int:
					return ReadFieldInt(reader);
				case D2OFieldType.Bool:
					return ReadFieldBool(reader);
				case D2OFieldType.String:
					return ReadFieldUTF(reader);
				case D2OFieldType.Double:
					return ReadFieldDouble(reader);
				case D2OFieldType.I18N:
					return ReadFieldI18n(reader);
				case D2OFieldType.UInt:
					return ReadFieldUInt(reader);
				default:
					return ReadFieldObject(reader);
			}
		}

		private object ReadFieldVector(IDataReader reader, D2OFieldDefinition field, int vectorDimension)
		{
			int num = reader.ReadInt();
			Type type = field.FieldType;
			for (int i = 0; i < vectorDimension; i++)
			{
				type = type.GetGenericArguments()[0];
			}
			if (!objectCreators.ContainsKey(type))
			{
				Func<object[], object> value = CreateObjectBuilder(type);
				objectCreators.Add(type, value);
			}
			IList list = objectCreators[type](new object[0]) as IList;
			for (int j = 0; j < num; j++)
			{
				vectorDimension++;
				list.Add(ReadField(reader, field, field.VectorTypes[vectorDimension - 1].Item1, vectorDimension));
				vectorDimension--;
			}
			return list;
		}

		private object ReadFieldObject(IDataReader reader)
		{
			int num = reader.ReadInt();
			if (num == -1431655766)
			{
				return null;
			}
			if (Classes.Keys.Contains(num))
			{
				return BuildObject(Classes[num], reader);
			}
			return null;
		}

		private static int ReadFieldInt(IDataReader reader)
		{
			return reader.ReadInt();
		}

		private static uint ReadFieldUInt(IDataReader reader)
		{
			return reader.ReadUInt();
		}

		private static bool ReadFieldBool(IDataReader reader)
		{
			return reader.ReadByte() != 0;
		}

		private static string ReadFieldUTF(IDataReader reader)
		{
			return reader.ReadUTF();
		}

		private static double ReadFieldDouble(IDataReader reader)
		{
			return reader.ReadDouble();
		}

		private static int ReadFieldI18n(IDataReader reader)
		{
			return reader.ReadInt();
		}

		internal IDataReader CloneReader()
		{
			lock (m_reader)
			{
				if (m_reader.Position > 0)
				{
					m_reader.Seek(0, SeekOrigin.Begin);
				}
				if (m_reader is FastBigEndianReader)
				{
					return new FastBigEndianReader((m_reader as FastBigEndianReader).Buffer);
				}
				Stream stream = new MemoryStream();
				((BigEndianReader)m_reader).BaseStream.CopyTo(stream);
				return new BigEndianReader(stream);
			}
		}

		public void Close()
		{
			lock (m_reader)
			{
				m_reader.Dispose();
			}
		}

		private static Func<object[], object> CreateObjectBuilder(Type classType, params FieldInfo[] fields)
		{
			IEnumerable<Type> enumerable = from entry in fields
										   select entry.FieldType;
			DynamicMethod dynamicMethod = new DynamicMethod(Guid.NewGuid().ToString("N"), typeof(object), new Type[1]
			{
				typeof(object[])
			}.ToArray());
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.DeclareLocal(classType);
			iLGenerator.DeclareLocal(classType);
			iLGenerator.Emit(OpCodes.Newobj, classType.GetConstructor(Type.EmptyTypes));
			iLGenerator.Emit(OpCodes.Stloc_0);
			for (int i = 0; i < fields.Length; i++)
			{
				iLGenerator.Emit(OpCodes.Ldloc_0);
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldc_I4, i);
				iLGenerator.Emit(OpCodes.Ldelem_Ref);
				if (fields[i].FieldType.IsClass)
				{
					iLGenerator.Emit(OpCodes.Castclass, fields[i].FieldType);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Unbox_Any, fields[i].FieldType);
				}
				iLGenerator.Emit(OpCodes.Stfld, fields[i]);
			}
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Stloc_1);
			iLGenerator.Emit(OpCodes.Ldloc_1);
			iLGenerator.Emit(OpCodes.Ret);
			return (Func<object[], object>)dynamicMethod.CreateDelegate(Expression.GetFuncType(new Type[2]
			{
				typeof(object[]),
				typeof(object)
			}.ToArray()));
		}
	}
}
