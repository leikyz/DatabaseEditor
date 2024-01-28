



















// Generated on 04/20/2016 12:03:44
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DungeonPartyFinderRegisterRequestMessage : Message
{

public const ushort Id = 6249;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> dungeonIds;
        

public DungeonPartyFinderRegisterRequestMessage()
{
}

public DungeonPartyFinderRegisterRequestMessage(IEnumerable<ushort> dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)dungeonIds.Count());
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVarUhShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            dungeonIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dungeonIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            

}


}


}