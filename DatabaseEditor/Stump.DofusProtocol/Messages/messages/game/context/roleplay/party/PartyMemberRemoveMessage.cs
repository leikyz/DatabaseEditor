



















// Generated on 04/20/2016 12:03:48
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyMemberRemoveMessage : AbstractPartyEventMessage
{

public const ushort Id = 5579;
public override ushort MessageId
{
    get { return Id; }
}

public ulong leavingPlayerId;
        

public PartyMemberRemoveMessage()
{
}

public PartyMemberRemoveMessage(uint partyId, ulong leavingPlayerId)
         : base(partyId)
        {
            this.leavingPlayerId = leavingPlayerId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(leavingPlayerId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            leavingPlayerId = reader.ReadVarUhLong();
            if (leavingPlayerId < 0 || leavingPlayerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on leavingPlayerId = " + leavingPlayerId + ", it doesn't respect the following condition : leavingPlayerId < 0 || leavingPlayerId > 9.007199254740992E15");
            

}


}


}