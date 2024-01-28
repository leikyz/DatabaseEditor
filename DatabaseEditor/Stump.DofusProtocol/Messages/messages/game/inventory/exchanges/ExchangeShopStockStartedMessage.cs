



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeShopStockStartedMessage : Message
{

public const ushort Id = 5910;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItemToSell> objectsInfos;
        

public ExchangeShopStockStartedMessage()
{
}

public ExchangeShopStockStartedMessage(IEnumerable<ObjectItemToSell> objectsInfos)
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
            objectsInfos = new ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as ObjectItemToSell[])[i].Deserialize(reader);
            }
            

}


}


}