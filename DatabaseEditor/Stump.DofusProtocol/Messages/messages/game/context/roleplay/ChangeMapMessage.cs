



















// Generated on 04/20/2016 12:03:31
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChangeMapMessage : Message
{

public const ushort Id = 221;
public override ushort MessageId
{
    get { return Id; }
}

public int mapId;
        

public ChangeMapMessage()
{
}

public ChangeMapMessage(int mapId)
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