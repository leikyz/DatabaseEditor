



















// Generated on 04/20/2016 12:03:52
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TreasureHuntShowLegendaryUIMessage : Message
{

public const ushort Id = 6498;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> availableLegendaryIds;
        

public TreasureHuntShowLegendaryUIMessage()
{
}

public TreasureHuntShowLegendaryUIMessage(IEnumerable<ushort> availableLegendaryIds)
        {
            this.availableLegendaryIds = availableLegendaryIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)availableLegendaryIds.Count());
            foreach (var entry in availableLegendaryIds)
            {
                 writer.WriteVarUhShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            availableLegendaryIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (availableLegendaryIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            

}


}


}