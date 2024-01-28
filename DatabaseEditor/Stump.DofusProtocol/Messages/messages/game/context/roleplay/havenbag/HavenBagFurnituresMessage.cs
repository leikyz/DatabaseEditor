



















// Generated on 04/20/2016 12:03:36
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class HavenBagFurnituresMessage : Message
{

public const ushort Id = 6634;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<HavenBagFurnitureInformation> furnituresInfos;
        

public HavenBagFurnituresMessage()
{
}

public HavenBagFurnituresMessage(IEnumerable<HavenBagFurnitureInformation> furnituresInfos)
        {
            this.furnituresInfos = furnituresInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)furnituresInfos.Count());
            foreach (var entry in furnituresInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            furnituresInfos = new HavenBagFurnitureInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (furnituresInfos as HavenBagFurnitureInformation[])[i].Deserialize(reader);
            }
            

}


}


}