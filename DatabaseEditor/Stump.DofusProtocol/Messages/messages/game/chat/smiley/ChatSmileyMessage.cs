



















// Generated on 04/20/2016 12:03:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatSmileyMessage : Message
{

public const ushort Id = 801;
public override ushort MessageId
{
    get { return Id; }
}

public double entityId;
        public ushort smileyId;
        public int accountId;
        

public ChatSmileyMessage()
{
}

public ChatSmileyMessage(double entityId, ushort smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarUhShort(smileyId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

entityId = reader.ReadDouble();
            if (entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15)
                throw new Exception("Forbidden value on entityId = " + entityId + ", it doesn't respect the following condition : entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15");
            smileyId = reader.ReadVarUhShort();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}