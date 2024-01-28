



















// Generated on 04/20/2016 12:04:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StorageInventoryContentMessage : InventoryContentMessage
{

public const ushort Id = 5646;
public override ushort MessageId
{
    get { return Id; }
}



public StorageInventoryContentMessage()
{
}

public StorageInventoryContentMessage(IEnumerable<ObjectItem> objects, uint kamas)
         : base(objects, kamas)
        {
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            

}


}


}