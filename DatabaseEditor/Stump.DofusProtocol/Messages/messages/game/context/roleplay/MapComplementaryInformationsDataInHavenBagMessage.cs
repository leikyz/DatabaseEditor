



















// Generated on 04/20/2016 12:03:31
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
{

public const ushort Id = 6622;
public override ushort MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations ownerInformations;
        public sbyte theme;
        public sbyte roomId;
        public sbyte maxRoomId;
        

public MapComplementaryInformationsDataInHavenBagMessage()
{
}

public MapComplementaryInformationsDataInHavenBagMessage(ushort subAreaId, int mapId, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<StatedElement> statedElements, IEnumerable<MapObstacle> obstacles, IEnumerable<FightCommonInformations> fights, Types.CharacterMinimalInformations ownerInformations, sbyte theme, sbyte roomId, sbyte maxRoomId)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights)
        {
            this.ownerInformations = ownerInformations;
            this.theme = theme;
            this.roomId = roomId;
            this.maxRoomId = maxRoomId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            ownerInformations.Serialize(writer);
            writer.WriteSByte(theme);
            writer.WriteSByte(roomId);
            writer.WriteSByte(maxRoomId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            ownerInformations = new Types.CharacterMinimalInformations();
            ownerInformations.Deserialize(reader);
            theme = reader.ReadSByte();
            roomId = reader.ReadSByte();
            if (roomId < 0)
                throw new Exception("Forbidden value on roomId = " + roomId + ", it doesn't respect the following condition : roomId < 0");
            maxRoomId = reader.ReadSByte();
            if (maxRoomId < 0)
                throw new Exception("Forbidden value on maxRoomId = " + maxRoomId + ", it doesn't respect the following condition : maxRoomId < 0");
            

}


}


}