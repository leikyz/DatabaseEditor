



















// Generated on 04/20/2016 12:03:29
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MountInformationInPaddockRequestMessage : Message
{

public const ushort Id = 5975;
public override ushort MessageId
{
    get { return Id; }
}

public int mapRideId;
        

public MountInformationInPaddockRequestMessage()
{
}

public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarInt(mapRideId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

mapRideId = reader.ReadVarInt();
            

}


}


}