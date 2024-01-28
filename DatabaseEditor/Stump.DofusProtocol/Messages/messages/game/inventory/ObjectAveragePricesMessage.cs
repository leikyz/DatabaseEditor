



















// Generated on 04/20/2016 12:04:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectAveragePricesMessage : Message
{

public const ushort Id = 6335;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> ids;
        public IEnumerable<uint> avgPrices;
        

public ObjectAveragePricesMessage()
{
}

public ObjectAveragePricesMessage(IEnumerable<ushort> ids, IEnumerable<uint> avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)ids.Count());
            foreach (var entry in ids)
            {
                 writer.WriteVarUhShort(entry);
            }
            writer.WriteUShort((ushort)avgPrices.Count());
            foreach (var entry in avgPrices)
            {
                 writer.WriteVarUhInt(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            ids = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ids as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            avgPrices = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (avgPrices as uint[])[i] = reader.ReadVarUhInt();
            }
            

}


}


}