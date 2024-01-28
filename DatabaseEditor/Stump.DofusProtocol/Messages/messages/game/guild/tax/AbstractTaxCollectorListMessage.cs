



















// Generated on 04/20/2016 12:04:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AbstractTaxCollectorListMessage : Message
{

public const ushort Id = 6568;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.TaxCollectorInformations> informations;
        

public AbstractTaxCollectorListMessage()
{
}

public AbstractTaxCollectorListMessage(IEnumerable<Types.TaxCollectorInformations> informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)informations.Count());
            foreach (var entry in informations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            informations = new Types.TaxCollectorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (informations as Types.TaxCollectorInformations[])[i] = ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadShort());
                 (informations as Types.TaxCollectorInformations[])[i].Deserialize(reader);
            }
            

}


}


}