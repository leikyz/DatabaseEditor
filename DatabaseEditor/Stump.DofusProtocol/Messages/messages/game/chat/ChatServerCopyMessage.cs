



















// Generated on 04/20/2016 12:03:18
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatServerCopyMessage : ChatAbstractServerMessage
{

public const ushort Id = 882;
public override ushort MessageId
{
    get { return Id; }
}

public ulong receiverId;
        public string receiverName;
        

public ChatServerCopyMessage()
{
}

public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, ulong receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(receiverId);
            writer.WriteUTF(receiverName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            receiverId = reader.ReadVarUhLong();
            if (receiverId < 0 || receiverId > 9.007199254740992E15)
                throw new Exception("Forbidden value on receiverId = " + receiverId + ", it doesn't respect the following condition : receiverId < 0 || receiverId > 9.007199254740992E15");
            receiverName = reader.ReadUTF();
            

}


}


}