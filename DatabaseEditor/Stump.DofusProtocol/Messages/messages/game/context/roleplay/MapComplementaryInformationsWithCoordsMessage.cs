



















// Generated on 04/20/2016 12:03:32
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
{

public const ushort Id = 6268;
public override ushort MessageId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        

public MapComplementaryInformationsWithCoordsMessage()
{
}

public MapComplementaryInformationsWithCoordsMessage(ushort subAreaId, int mapId, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<StatedElement> statedElements, IEnumerable<MapObstacle> obstacles, IEnumerable<FightCommonInformations> fights, short worldX, short worldY)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            

}


}


}