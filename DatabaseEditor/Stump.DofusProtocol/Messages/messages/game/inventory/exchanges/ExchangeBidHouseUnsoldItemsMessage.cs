



















// Generated on 04/20/2016 12:04:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHouseUnsoldItemsMessage : Message
{

public const ushort Id = 6612;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItemGenericQuantity> items;
        

public ExchangeBidHouseUnsoldItemsMessage()
{
}

public ExchangeBidHouseUnsoldItemsMessage(IEnumerable<ObjectItemGenericQuantity> items)
        {
            this.items = items;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)items.Count());
            foreach (var entry in items)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            items = new ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (items as ObjectItemGenericQuantity[])[i].Deserialize(reader);
            }
            

}


}


}