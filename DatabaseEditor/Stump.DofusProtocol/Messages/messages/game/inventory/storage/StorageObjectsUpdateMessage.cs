



















// Generated on 04/20/2016 12:04:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StorageObjectsUpdateMessage : Message
{

public const ushort Id = 6036;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> objectList;
        

public StorageObjectsUpdateMessage()
{
}

public StorageObjectsUpdateMessage(IEnumerable<ObjectItem> objectList)
        {
            this.objectList = objectList;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)objectList.Count());
            foreach (var entry in objectList)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            objectList = new ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectList as ObjectItem[])[i].Deserialize(reader);
            }
            

}


}


}