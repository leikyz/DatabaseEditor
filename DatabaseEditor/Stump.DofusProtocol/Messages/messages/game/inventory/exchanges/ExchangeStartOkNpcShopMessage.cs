



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartOkNpcShopMessage : Message
{

public const ushort Id = 5761;
public override ushort MessageId
{
    get { return Id; }
}

public double npcSellerId;
        public ushort tokenId;
        public IEnumerable<ObjectItemToSellInNpcShop> objectsInfos;
        

public ExchangeStartOkNpcShopMessage()
{
}

public ExchangeStartOkNpcShopMessage(double npcSellerId, ushort tokenId, IEnumerable<ObjectItemToSellInNpcShop> objectsInfos)
        {
            this.npcSellerId = npcSellerId;
            this.tokenId = tokenId;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(npcSellerId);
            writer.WriteVarUhShort(tokenId);
            writer.WriteUShort((ushort)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

npcSellerId = reader.ReadDouble();
            if (npcSellerId < -9.007199254740992E15 || npcSellerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on npcSellerId = " + npcSellerId + ", it doesn't respect the following condition : npcSellerId < -9.007199254740992E15 || npcSellerId > 9.007199254740992E15");
            tokenId = reader.ReadVarUhShort();
            if (tokenId < 0)
                throw new Exception("Forbidden value on tokenId = " + tokenId + ", it doesn't respect the following condition : tokenId < 0");
            var limit = reader.ReadUShort();
            objectsInfos = new ObjectItemToSellInNpcShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as ObjectItemToSellInNpcShop[])[i].Deserialize(reader);
            }
            

}


}


}