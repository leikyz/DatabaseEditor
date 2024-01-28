



















// Generated on 04/20/2016 12:03:32
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MapObstacleUpdateMessage : Message
{

public const ushort Id = 6051;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<MapObstacle> obstacles;
        

public MapObstacleUpdateMessage()
{
}

public MapObstacleUpdateMessage(IEnumerable<MapObstacle> obstacles)
        {
            this.obstacles = obstacles;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)obstacles.Count());
            foreach (var entry in obstacles)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            obstacles = new MapObstacle[limit];
            for (int i = 0; i < limit; i++)
            {
                 (obstacles as MapObstacle[])[i].Deserialize(reader);
            }
            

}


}


}