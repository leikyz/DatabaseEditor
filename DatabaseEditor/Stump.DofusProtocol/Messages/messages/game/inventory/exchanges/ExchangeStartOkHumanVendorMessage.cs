



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartOkHumanVendorMessage : Message
{

public const ushort Id = 5767;
public override ushort MessageId
{
    get { return Id; }
}

public double sellerId;
        public IEnumerable<ObjectItemToSellInHumanVendorShop> objectsInfos;
        

public ExchangeStartOkHumanVendorMessage()
{
}

public ExchangeStartOkHumanVendorMessage(double sellerId, IEnumerable<ObjectItemToSellInHumanVendorShop> objectsInfos)
        {
            this.sellerId = sellerId;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(sellerId);
            writer.WriteUShort((ushort)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

sellerId = reader.ReadDouble();
            if (sellerId < -9.007199254740992E15 || sellerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on sellerId = " + sellerId + ", it doesn't respect the following condition : sellerId < -9.007199254740992E15 || sellerId > 9.007199254740992E15");
            var limit = reader.ReadUShort();
            objectsInfos = new ObjectItemToSellInHumanVendorShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as ObjectItemToSellInHumanVendorShop[])[i].Deserialize(reader);
            }
            

}


}


}