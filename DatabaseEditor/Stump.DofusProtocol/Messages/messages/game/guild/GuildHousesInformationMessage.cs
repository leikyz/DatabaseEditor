



















// Generated on 04/20/2016 12:03:57
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildHousesInformationMessage : Message
{

public const ushort Id = 5919;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<HouseInformationsForGuild> housesInformations;
        

public GuildHousesInformationMessage()
{
}

public GuildHousesInformationMessage(IEnumerable<HouseInformationsForGuild> housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)housesInformations.Count());
            foreach (var entry in housesInformations)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            housesInformations = new HouseInformationsForGuild[limit];
            for (int i = 0; i < limit; i++)
            {
                 (housesInformations as HouseInformationsForGuild[])[i].Deserialize(reader);
            }
            

}


}


}