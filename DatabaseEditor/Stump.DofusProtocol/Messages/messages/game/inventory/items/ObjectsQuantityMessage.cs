



















// Generated on 04/20/2016 12:04:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectsQuantityMessage : Message
{

public const ushort Id = 6206;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItemQuantity> objectsUIDAndQty;
        

public ObjectsQuantityMessage()
{
}

public ObjectsQuantityMessage(IEnumerable<ObjectItemQuantity> objectsUIDAndQty)
        {
            this.objectsUIDAndQty = objectsUIDAndQty;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)objectsUIDAndQty.Count());
            foreach (var entry in objectsUIDAndQty)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            objectsUIDAndQty = new ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsUIDAndQty as ObjectItemQuantity[])[i].Deserialize(reader);
            }
            

}


}


}