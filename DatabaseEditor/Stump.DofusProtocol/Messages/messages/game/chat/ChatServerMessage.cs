



















// Generated on 04/20/2016 12:03:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatServerMessage : ChatAbstractServerMessage
{

public const ushort Id = 881;
public override ushort MessageId
{
    get { return Id; }
}

public double senderId;
        public string senderName;
        public int senderAccountId;
        

public ChatServerMessage()
{
}

public ChatServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId)
         : base(channel, content, timestamp, fingerprint)
        {
            this.senderId = senderId;
            this.senderName = senderName;
            this.senderAccountId = senderAccountId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteDouble(senderId);
            writer.WriteUTF(senderName);
            writer.WriteInt(senderAccountId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            senderId = reader.ReadDouble();
            if (senderId < -9.007199254740992E15 || senderId > 9.007199254740992E15)
                throw new Exception("Forbidden value on senderId = " + senderId + ", it doesn't respect the following condition : senderId < -9.007199254740992E15 || senderId > 9.007199254740992E15");
            senderName = reader.ReadUTF();
            senderAccountId = reader.ReadInt();
            if (senderAccountId < 0)
                throw new Exception("Forbidden value on senderAccountId = " + senderAccountId + ", it doesn't respect the following condition : senderAccountId < 0");
            

}


}


}