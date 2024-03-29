



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectGroundListAddedMessage : Message
{

public const ushort Id = 5925;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> cells;
        public IEnumerable<ushort> referenceIds;
        

public ObjectGroundListAddedMessage()
{
}

public ObjectGroundListAddedMessage(IEnumerable<ushort> cells, IEnumerable<ushort> referenceIds)
        {
            this.cells = cells;
            this.referenceIds = referenceIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)cells.Count());
            foreach (var entry in cells)
            {
                 writer.WriteVarUhShort(entry);
            }
            writer.WriteUShort((ushort)referenceIds.Count());
            foreach (var entry in referenceIds)
            {
                 writer.WriteVarUhShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            cells = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cells as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            referenceIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (referenceIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            

}


}


}