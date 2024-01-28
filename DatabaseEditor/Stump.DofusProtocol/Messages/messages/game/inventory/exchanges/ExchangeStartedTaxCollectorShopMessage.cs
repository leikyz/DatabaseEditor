



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartedTaxCollectorShopMessage : Message
{

public const ushort Id = 6664;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> objects;
        public uint kamas;
        

public ExchangeStartedTaxCollectorShopMessage()
{
}

public ExchangeStartedTaxCollectorShopMessage(IEnumerable<ObjectItem> objects, uint kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)objects.Count());
            foreach (var entry in objects)
            {
                entry.Serialize(writer);
            }
            writer.WriteVarUhInt(kamas);
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            objects = new ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objects as ObjectItem[])[i].Deserialize(reader);
            }
            kamas = reader.ReadVarUhInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}