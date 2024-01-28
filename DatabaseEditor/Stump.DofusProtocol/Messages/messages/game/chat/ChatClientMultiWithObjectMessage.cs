



















// Generated on 04/20/2016 12:03:18
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatClientMultiWithObjectMessage : ChatClientMultiMessage
{

public const ushort Id = 862;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> objects;
        

public ChatClientMultiWithObjectMessage()
{
}

public ChatClientMultiWithObjectMessage(string content, sbyte channel, IEnumerable<ObjectItem> objects)
         : base(content, channel)
        {
            this.objects = objects;
        }


        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            var objects_before = writer.Position;
            var objects_count = 0;
            writer.WriteShort(0);
            foreach (var entry in objects)
            {
                entry.Serialize(writer);
                objects_count++;
            }
            var objects_after = writer.Position;
            writer.Seek((int)objects_before);
            writer.WriteShort((short)objects_count);
            writer.Seek((int)objects_after);

        }

        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadShort();
            var objects_ = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                objects_[i] = new Types.ObjectItem();
                objects_[i].Deserialize(reader);
            }
            objects = objects_;
        }

    }
}


