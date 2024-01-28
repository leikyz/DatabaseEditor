



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeTypesItemsExchangerDescriptionForUserMessage : Message
{

public const ushort Id = 5752;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<BidExchangerObjectInfo> itemTypeDescriptions;
        

public ExchangeTypesItemsExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesItemsExchangerDescriptionForUserMessage(IEnumerable<BidExchangerObjectInfo> itemTypeDescriptions)
        {
            this.itemTypeDescriptions = itemTypeDescriptions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)itemTypeDescriptions.Count());
            foreach (var entry in itemTypeDescriptions)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            itemTypeDescriptions = new BidExchangerObjectInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (itemTypeDescriptions as BidExchangerObjectInfo[])[i].Deserialize(reader);
            }
            

}


}


}