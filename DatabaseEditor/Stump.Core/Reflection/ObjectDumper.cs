using System;
using System.Collections;
using System.Reflection;
using System.Text;

namespace Stump.Core.Reflection
{
    public class ObjectDumper
    {
        private const int DepthDisplayLimit = 5;
        private readonly int m_indentSize;
        private readonly StringBuilder m_stringBuilder;
        private int m_level;

        public ObjectDumper(int indentSize)
        {
            m_indentSize = indentSize;
            m_stringBuilder = new StringBuilder();
        }

        public Func<MemberInfo, bool> MemberPredicate { get; set; }

        public static string Dump(object element)
        {
            return Dump(element, 2);
        }

        public static string Dump(object element, int indentSize)
        {
            var objectDumper = new ObjectDumper(indentSize);
            return objectDumper.DumpElement(element);
        }

        public string DumpElement(object element)
        {
            string result;
            if (m_level > DepthDisplayLimit)
            {
                result = "... (limit reached)";
            }
            else
            {
                if (element == null || element is ValueType || element is string)
                {
                    Write(FormatValue(element));
                }
                else
                {
                    var type = element.GetType();
                    if (!typeof (IEnumerable).IsAssignableFrom(type))
                    {
                        Write("{{{0}}}", type.FullName);
                        m_level++;
                    }
                    var enumerable = element as IEnumerable;
                    if (enumerable != null)
                    {
                        var num = 0;
                        foreach (var current in enumerable)
                        {
                            num++;
                            if (current is IEnumerable && !(current is string))
                            {
                                m_level++;
                                DumpElement(current);
                                m_level--;
                            }
                            else
                            {
                                DumpElement(current);
                            }
                        }
                        if (num == 0)
                        {
                            Write("-Empty-");
                        }
                    }
                    else
                    {
                        var members =
                            element.GetType()
                                .GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        var array = members;
                        for (var i = 0; i < array.Length; i++)
                        {
                            var memberInfo = array[i];
                            if (!(memberInfo is EventInfo))
                            {
                                var fieldInfo = memberInfo as FieldInfo;
                                var propertyInfo = memberInfo as PropertyInfo;
                                if ((!(fieldInfo == null) || !(propertyInfo == null)) &&
                                    (MemberPredicate == null || MemberPredicate(memberInfo)))
                                {
                                    var type2 = fieldInfo != null ? fieldInfo.FieldType : propertyInfo.PropertyType;
                                    if (!(propertyInfo != null) || propertyInfo.GetIndexParameters().Length <= 0)
                                    {
                                        var obj = fieldInfo != null
                                            ? fieldInfo.GetValue(element)
                                            : propertyInfo.GetValue(element, null);
                                        if (!(obj is MulticastDelegate))
                                        {
                                            if (type2.IsValueType || type2 == typeof (string))
                                            {
                                                Write("{0}: {1}", memberInfo.Name, FormatValue(obj));
                                            }
                                            else
                                            {
                                                Write("{0}: {1}", memberInfo.Name,
                                                    typeof (IEnumerable).IsAssignableFrom(type2) ? "..." : "{ }");
                                                m_level++;
                                                DumpElement(obj);
                                                m_level--;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!typeof (IEnumerable).IsAssignableFrom(type))
                    {
                        m_level--;
                    }
                }
                result = m_stringBuilder.ToString();
            }
            return result;
        }

        private void Write(string value, params object[] args)
        {
            var str = new string(' ', m_level*m_indentSize);
            if (args != null)
            {
                value = string.Format(value, args);
            }
            m_stringBuilder.AppendLine(str + value);
        }

        private string FormatValue(object o)
        {
            string result;
            if (o == null)
            {
                result = "null";
            }
            else
            {
                if (o is DateTime)
                {
                    result = ((DateTime) o).ToShortDateString();
                }
                else
                {
                    if (o is string)
                    {
                        result = string.Format("\"{0}\"", o);
                    }
                    else
                    {
                        if (o is ValueType)
                        {
                            result = o.ToString();
                        }
                        else
                        {
                            if (o is IEnumerable)
                            {
                                result = "...";
                            }
                            else
                            {
                                result = "{ }";
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}