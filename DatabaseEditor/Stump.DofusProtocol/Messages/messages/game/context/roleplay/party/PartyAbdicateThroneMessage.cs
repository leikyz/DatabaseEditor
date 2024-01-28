



















// Generated on 04/20/2016 12:03:44
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyAbdicateThroneMessage : AbstractPartyMessage
{

public const ushort Id = 6080;
public override ushort MessageId
{
    get { return Id; }
}

public ulong playerId;
        

public PartyAbdicateThroneMessage()
{
}

public PartyAbdicateThroneMessage(uint partyId, ulong playerId)
         : base(partyId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(playerId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            

}


}


}