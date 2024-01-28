



















// Generated on 04/20/2016 12:03:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatServerWithObjectMessage : ChatServerMessage
{

public const ushort Id = 883;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> objects;
        

public ChatServerWithObjectMessage()
{
}

public ChatServerWithObjectMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId, IEnumerable<ObjectItem> objects)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, senderAccountId)
        {
            this.objects = objects;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)objects.Count());
            foreach (var entry in objects)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objects = new ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objects as ObjectItem[])[i].Deserialize(reader);
            }
            

}


}


}