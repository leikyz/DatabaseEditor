



















// Generated on 04/20/2016 12:03:44
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyAcceptInvitationMessage : AbstractPartyMessage
{

public const ushort Id = 5580;
public override ushort MessageId
{
    get { return Id; }
}



public PartyAcceptInvitationMessage()
{
}

public PartyAcceptInvitationMessage(uint partyId)
         : base(partyId)
        {
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            

}


}


}