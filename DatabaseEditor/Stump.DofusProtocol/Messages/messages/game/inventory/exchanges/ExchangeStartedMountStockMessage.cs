



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartedMountStockMessage : Message
{

public const ushort Id = 5984;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> objectsInfos;
        

public ExchangeStartedMountStockMessage()
{
}

public ExchangeStartedMountStockMessage(IEnumerable<ObjectItem> objectsInfos)
        {
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            objectsInfos = new ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as ObjectItem[])[i].Deserialize(reader);
            }
            

}


}


}