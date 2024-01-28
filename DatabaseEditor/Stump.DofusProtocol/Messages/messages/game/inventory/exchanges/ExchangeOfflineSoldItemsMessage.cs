



















// Generated on 04/20/2016 12:04:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeOfflineSoldItemsMessage : Message
{

public const ushort Id = 6613;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItemGenericQuantityPrice> bidHouseItems;
        public IEnumerable<ObjectItemGenericQuantityPrice> merchantItems;
        

public ExchangeOfflineSoldItemsMessage()
{
}

public ExchangeOfflineSoldItemsMessage(IEnumerable<ObjectItemGenericQuantityPrice> bidHouseItems, IEnumerable<ObjectItemGenericQuantityPrice> merchantItems)
        {
            this.bidHouseItems = bidHouseItems;
            this.merchantItems = merchantItems;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)bidHouseItems.Count());
            foreach (var entry in bidHouseItems)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)merchantItems.Count());
            foreach (var entry in merchantItems)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            bidHouseItems = new ObjectItemGenericQuantityPrice[limit];
            for (int i = 0; i < limit; i++)
            {
                 (bidHouseItems as ObjectItemGenericQuantityPrice[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            merchantItems = new ObjectItemGenericQuantityPrice[limit];
            for (int i = 0; i < limit; i++)
            {
                 (merchantItems as ObjectItemGenericQuantityPrice[])[i].Deserialize(reader);
            }
            

}


}


}