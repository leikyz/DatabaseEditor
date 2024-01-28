



















// Generated on 04/20/2016 12:03:45
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyDeletedMessage : AbstractPartyMessage
{

public const ushort Id = 6261;
public override ushort MessageId
{
    get { return Id; }
}



public PartyDeletedMessage()
{
}

public PartyDeletedMessage(uint partyId)
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