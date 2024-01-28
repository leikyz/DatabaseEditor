



















// Generated on 04/20/2016 12:03:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameContextMoveMultipleElementsMessage : Message
{

public const ushort Id = 254;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<EntityMovementInformations> movements;
        

public GameContextMoveMultipleElementsMessage()
{
}

public GameContextMoveMultipleElementsMessage(IEnumerable<EntityMovementInformations> movements)
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
            movements = new EntityMovementInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (movements as EntityMovementInformations[])[i].Deserialize(reader);
            }
            

}


}


}