



















// Generated on 04/20/2016 12:04:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeShopStockMultiMovementUpdatedMessage : Message
{

public const ushort Id = 6038;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItemToSell> objectInfoList;
        

public ExchangeShopStockMultiMovementUpdatedMessage()
{
}

public ExchangeShopStockMultiMovementUpdatedMessage(IEnumerable<ObjectItemToSell> objectInfoList)
        {
            this.objectInfoList = objectInfoList;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)objectInfoList.Count());
            foreach (var entry in objectInfoList)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            objectInfoList = new ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectInfoList as ObjectItemToSell[])[i].Deserialize(reader);
            }
            

}


}


}