



















// Generated on 04/20/2016 12:04:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectsAddedMessage : Message
{

public const ushort Id = 6033;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> @object;
        

public ObjectsAddedMessage()
{
}

public ObjectsAddedMessage(IEnumerable<ObjectItem> @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)@object.Count());
            foreach (var entry in @object)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            @object = new ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (@object as ObjectItem[])[i].Deserialize(reader);
            }
            

}


}


}