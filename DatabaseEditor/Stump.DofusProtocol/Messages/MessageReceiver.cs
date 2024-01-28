using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Stump.Core.IO;
using Stump.Core.Reflection;

namespace Stump.DofusProtocol.Messages
{
    public static class MessageReceiver
    {
        private static readonly Dictionary<ushort, Type> Messages = new Dictionary<ushort, Type>();
        private static readonly Dictionary<ushort, Func<Message>> Constructors = new Dictionary<ushort, Func<Message>>();

        public static void Initialize()
        {
            var assembly = Assembly.GetAssembly(typeof (MessageReceiver));
            foreach (var type in assembly.GetTypes().Where(x => x.IsSubclassOf(typeof (Message))))
            {
                var field = type.GetField("Id");
                if (field != null)
                {
                    var num = (ushort) field.GetValue(type);
                    if (Messages.ContainsKey(num))
                    {
                        throw new AmbiguousMatchException(
                            $"MessageReceiver() => {num} item is already in the dictionary, old type is : {Messages[num]}, new type is  {type}");
                    }
                    Messages.Add(num, type);
                    var constructor = type.GetConstructor(Type.EmptyTypes);
                    if (constructor == null)
                    {
                        throw new Exception($"'{type}' doesn't implemented a parameterless constructor");
                    }
                    Constructors.Add(num, constructor.CreateDelegate<Func<Message>>());
                }
            }
        }

        public static Message BuildMessage(ushort id, ICustomDataInput reader)
        {
            if (!Messages.ContainsKey(id))
            {
                return null;
            }
            var message = Constructors[id]();
            if (message == null)
            {
                return null;
            }
            message.Unpack(reader);
            return message;
        }

        public static Type GetMessageType(ushort id)
        {
            if (!Messages.ContainsKey(id))
            {
                return null;
            }
            return Messages[id];
        }

        [Serializable]
        public class MessageNotFoundException : Exception
        {
            public MessageNotFoundException()
            {
            }

            public MessageNotFoundException(string message)
                : base(message)
            {
            }

            public MessageNotFoundException(string message, Exception inner)
                : base(message, inner)
            {
            }

            protected MessageNotFoundException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }
        }
    }
}