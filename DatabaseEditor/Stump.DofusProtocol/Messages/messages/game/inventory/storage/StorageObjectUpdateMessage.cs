



















// Generated on 04/20/2016 12:04:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StorageObjectUpdateMessage : Message
{

public const ushort Id = 5647;
public override ushort MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public StorageObjectUpdateMessage()
{
}

public StorageObjectUpdateMessage(Types.ObjectItem @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

@object.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}