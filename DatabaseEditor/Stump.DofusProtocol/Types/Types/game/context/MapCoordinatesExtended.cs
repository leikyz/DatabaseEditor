



















// Generated on 04/20/2016 12:44:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class MapCoordinatesExtended : MapCoordinatesAndId
{

public const short Id = 176;
public override short TypeId
{
    get { return Id; }
}

public ushort subAreaId;
        

public MapCoordinatesExtended()
{
}

public MapCoordinatesExtended(short worldX, short worldY, int mapId, ushort subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(subAreaId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}