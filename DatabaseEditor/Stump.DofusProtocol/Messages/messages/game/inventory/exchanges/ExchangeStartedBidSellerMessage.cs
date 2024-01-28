



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartedBidSellerMessage : Message
{

public const ushort Id = 5905;
public override ushort MessageId
{
    get { return Id; }
}

public Types.SellerBuyerDescriptor sellerDescriptor;
        public IEnumerable<ObjectItemToSellInBid> objectsInfos;
        

public ExchangeStartedBidSellerMessage()
{
}

public ExchangeStartedBidSellerMessage(Types.SellerBuyerDescriptor sellerDescriptor, IEnumerable<ObjectItemToSellInBid> objectsInfos)
        {
            this.sellerDescriptor = sellerDescriptor;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

sellerDescriptor.Serialize(writer);
            writer.WriteUShort((ushort)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

sellerDescriptor = new Types.SellerBuyerDescriptor();
            sellerDescriptor.Deserialize(reader);
            var limit = reader.ReadUShort();
            objectsInfos = new ObjectItemToSellInBid[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as ObjectItemToSellInBid[])[i].Deserialize(reader);
            }
            

}


}


}