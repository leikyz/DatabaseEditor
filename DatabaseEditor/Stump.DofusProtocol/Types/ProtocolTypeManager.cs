using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Stump.Core.Reflection;
using Stump.DofusProtocol.Messages;

namespace Stump.DofusProtocol.Types
{
    public static class ProtocolTypeManager
    {
        private static readonly Dictionary<short, Type> m_types = new Dictionary<short, Type>(200);

        private static readonly Dictionary<short, Func<object>> m_typesConstructors =
            new Dictionary<short, Func<object>>(200);

        public static void Initialize()
        {
            var assembly = Assembly.GetAssembly(typeof (Version));
            foreach (var type in assembly.GetTypes().Where(x => !x.IsSubclassOf(typeof (Message))))
            {
                var field = type.GetField("Id");
                if (field != null)
                {
                    var key = (short) field.GetValue(type);
                    m_types.Add(key, type);
                    var constructor = type.GetConstructor(Type.EmptyTypes);
                    if (constructor == null)
                    {
                        throw new Exception(string.Format("'{0}' doesn't implemented a parameterless constructor", type));
                    }
                    m_typesConstructors.Add(key, constructor.CreateDelegate<Func<object>>());
                }
            }
        }

        public static T GetInstance<T>(short id) where T : class
        {
            if (!m_types.ContainsKey(id))
            {
                throw new ProtocolTypeNotFoundException(string.Format("Type <id:{0}> doesn't exist", id));
            }
            return m_typesConstructors[id]() as T;
        }

        [Serializable]
        public class ProtocolTypeNotFoundException : Exception
        {
            public ProtocolTypeNotFoundException()
            {
            }

            public ProtocolTypeNotFoundException(string message) : base(message)
            {
            }

            public ProtocolTypeNotFoundException(string message, Exception inner) : base(message, inner)
            {
            }

            protected ProtocolTypeNotFoundException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
}