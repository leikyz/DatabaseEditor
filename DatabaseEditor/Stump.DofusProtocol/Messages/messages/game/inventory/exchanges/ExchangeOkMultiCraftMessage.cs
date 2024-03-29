



















// Generated on 04/20/2016 12:04:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeOkMultiCraftMessage : Message
{

public const ushort Id = 5768;
public override ushort MessageId
{
    get { return Id; }
}

public ulong initiatorId;
        public ulong otherId;
        public sbyte role;
        

public ExchangeOkMultiCraftMessage()
{
}

public ExchangeOkMultiCraftMessage(ulong initiatorId, ulong otherId, sbyte role)
        {
            this.initiatorId = initiatorId;
            this.otherId = otherId;
            this.role = role;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(initiatorId);
            writer.WriteVarUhLong(otherId);
            writer.WriteSByte(role);
            

}

public override void Deserialize(ICustomDataInput reader)
{

initiatorId = reader.ReadVarUhLong();
            if (initiatorId < 0 || initiatorId > 9.007199254740992E15)
                throw new Exception("Forbidden value on initiatorId = " + initiatorId + ", it doesn't respect the following condition : initiatorId < 0 || initiatorId > 9.007199254740992E15");
            otherId = reader.ReadVarUhLong();
            if (otherId < 0 || otherId > 9.007199254740992E15)
                throw new Exception("Forbidden value on otherId = " + otherId + ", it doesn't respect the following condition : otherId < 0 || otherId > 9.007199254740992E15");
            role = reader.ReadSByte();
            

}


}


}