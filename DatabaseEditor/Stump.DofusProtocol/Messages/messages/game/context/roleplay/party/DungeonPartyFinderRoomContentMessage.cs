



















// Generated on 04/20/2016 12:03:44
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DungeonPartyFinderRoomContentMessage : Message
{

public const ushort Id = 6247;
public override ushort MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public IEnumerable<DungeonPartyFinderPlayer> players;
        

public DungeonPartyFinderRoomContentMessage()
{
}

public DungeonPartyFinderRoomContentMessage(ushort dungeonId, IEnumerable<DungeonPartyFinderPlayer> players)
        {
            this.dungeonId = dungeonId;
            this.players = players;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(dungeonId);
            writer.WriteUShort((ushort)players.Count());
            foreach (var entry in players)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            players = new DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 (players as DungeonPartyFinderPlayer[])[i].Deserialize(reader);
            }
            

}


}


}