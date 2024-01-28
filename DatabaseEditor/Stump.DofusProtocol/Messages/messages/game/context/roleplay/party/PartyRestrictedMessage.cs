



















// Generated on 04/20/2016 12:03:49
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyRestrictedMessage : AbstractPartyMessage
{

public const ushort Id = 6175;
public override ushort MessageId
{
    get { return Id; }
}

public bool restricted;
        

public PartyRestrictedMessage()
{
}

public PartyRestrictedMessage(uint partyId, bool restricted)
         : base(partyId)
        {
            this.restricted = restricted;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteBoolean(restricted);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            restricted = reader.ReadBoolean();
            

}


}


}