



















// Generated on 04/20/2016 12:03:30
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MountSterilizedMessage : Message
{

public const ushort Id = 5977;
public override ushort MessageId
{
    get { return Id; }
}

public int mountId;
        

public MountSterilizedMessage()
{
}

public MountSterilizedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarInt(mountId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

mountId = reader.ReadVarInt();
            

}


}


}