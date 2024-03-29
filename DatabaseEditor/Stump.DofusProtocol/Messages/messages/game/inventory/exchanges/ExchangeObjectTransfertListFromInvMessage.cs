



















// Generated on 04/20/2016 12:04:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeObjectTransfertListFromInvMessage : Message
{

public const ushort Id = 6183;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<uint> ids;
        

public ExchangeObjectTransfertListFromInvMessage()
{
}

public ExchangeObjectTransfertListFromInvMessage(IEnumerable<uint> ids)
        {
            this.ids = ids;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)ids.Count());
            foreach (var entry in ids)
            {
                 writer.WriteVarUhInt(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ids as uint[])[i] = reader.ReadVarUhInt();
            }
            

}


}


}