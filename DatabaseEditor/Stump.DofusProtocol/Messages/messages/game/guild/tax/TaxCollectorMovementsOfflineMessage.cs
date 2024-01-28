



















// Generated on 04/20/2016 12:04:01
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TaxCollectorMovementsOfflineMessage : Message
{

public const ushort Id = 6611;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<TaxCollectorMovement> movements;
        

public TaxCollectorMovementsOfflineMessage()
{
}

public TaxCollectorMovementsOfflineMessage(IEnumerable<TaxCollectorMovement> movements)
        {
            this.movements = movements;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)movements.Count());
            foreach (var entry in movements)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            movements = new TaxCollectorMovement[limit];
            for (int i = 0; i < limit; i++)
            {

                (movements as TaxCollectorMovement[])[i] = new TaxCollectorMovement();
                (movements as TaxCollectorMovement[])[i].Deserialize(reader);
            }
            

}


}


}