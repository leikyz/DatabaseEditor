



















// Generated on 04/20/2016 12:04:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ZaapRespawnUpdatedMessage : Message
{

public const ushort Id = 6571;
public override ushort MessageId
{
    get { return Id; }
}

public int mapId;
        

public ZaapRespawnUpdatedMessage()
{
}

public ZaapRespawnUpdatedMessage(int mapId)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(mapId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}