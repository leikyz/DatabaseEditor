



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameDataPlayFarmObjectAnimationMessage : Message
{

public const ushort Id = 6026;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> cellId;
        

public GameDataPlayFarmObjectAnimationMessage()
{
}

public GameDataPlayFarmObjectAnimationMessage(IEnumerable<ushort> cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)cellId.Count());
            foreach (var entry in cellId)
            {
                 writer.WriteVarUhShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            cellId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cellId as ushort[])[i] = reader.ReadVarUhShort();
            }
            

}


}


}