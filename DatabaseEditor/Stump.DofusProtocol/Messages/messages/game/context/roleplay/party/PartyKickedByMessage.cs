



















// Generated on 04/20/2016 12:03:46
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyKickedByMessage : AbstractPartyMessage
{

public const ushort Id = 5590;
public override ushort MessageId
{
    get { return Id; }
}

public ulong kickerId;
        

public PartyKickedByMessage()
{
}

public PartyKickedByMessage(uint partyId, ulong kickerId)
         : base(partyId)
        {
            this.kickerId = kickerId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(kickerId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            kickerId = reader.ReadVarUhLong();
            if (kickerId < 0 || kickerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on kickerId = " + kickerId + ", it doesn't respect the following condition : kickerId < 0 || kickerId > 9.007199254740992E15");
            

}


}


}