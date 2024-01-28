



















// Generated on 04/20/2016 12:03:47
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyLocateMembersMessage : AbstractPartyMessage
{

public const ushort Id = 5595;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<PartyMemberGeoPosition> geopositions;
        

public PartyLocateMembersMessage()
{
}

public PartyLocateMembersMessage(uint partyId, IEnumerable<PartyMemberGeoPosition> geopositions)
         : base(partyId)
        {
            this.geopositions = geopositions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)geopositions.Count());
            foreach (var entry in geopositions)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            geopositions = new PartyMemberGeoPosition[limit];
            for (int i = 0; i < limit; i++)
            {
                 (geopositions as PartyMemberGeoPosition[])[i].Deserialize(reader);
            }
            

}


}


}