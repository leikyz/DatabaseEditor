



















// Generated on 04/20/2016 12:03:45
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
{

public const ushort Id = 6256;
public override ushort MessageId
{
    get { return Id; }
}

public ulong cancelerId;
        

public PartyInvitationCancelledForGuestMessage()
{
}

public PartyInvitationCancelledForGuestMessage(uint partyId, ulong cancelerId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(cancelerId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadVarUhLong();
            if (cancelerId < 0 || cancelerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0 || cancelerId > 9.007199254740992E15");
            

}


}


}