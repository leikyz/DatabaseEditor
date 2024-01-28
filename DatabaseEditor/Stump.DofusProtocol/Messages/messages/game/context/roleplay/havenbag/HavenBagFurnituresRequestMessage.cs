



















// Generated on 04/20/2016 12:03:36
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class HavenBagFurnituresRequestMessage : Message
{

public const ushort Id = 6637;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> cellIds;
        public IEnumerable<int> funitureIds;
        public IEnumerable<sbyte> orientations;
        

public HavenBagFurnituresRequestMessage()
{
}

public HavenBagFurnituresRequestMessage(IEnumerable<ushort> cellIds, IEnumerable<int> funitureIds, IEnumerable<sbyte> orientations)
        {
            this.cellIds = cellIds;
            this.funitureIds = funitureIds;
            this.orientations = orientations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)cellIds.Count());
            foreach (var entry in cellIds)
            {
                 writer.WriteVarUhShort(entry);
            }
            writer.WriteUShort((ushort)funitureIds.Count());
            foreach (var entry in funitureIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)orientations.Count());
            foreach (var entry in orientations)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            cellIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cellIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            funitureIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (funitureIds as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            orientations = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (orientations as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}