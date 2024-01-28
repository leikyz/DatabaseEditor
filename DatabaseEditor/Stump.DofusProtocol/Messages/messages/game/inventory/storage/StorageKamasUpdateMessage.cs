



















// Generated on 04/20/2016 12:04:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StorageKamasUpdateMessage : Message
{

public const ushort Id = 5645;
public override ushort MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public StorageKamasUpdateMessage()
{
}

public StorageKamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(kamasTotal);
            

}

public override void Deserialize(ICustomDataInput reader)
{

kamasTotal = reader.ReadInt();
            

}


}


}