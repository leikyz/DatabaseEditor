



















// Generated on 04/20/2016 12:03:44
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DungeonPartyFinderRoomContentUpdateMessage : Message
{

public const ushort Id = 6250;
public override ushort MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public IEnumerable<DungeonPartyFinderPlayer> addedPlayers;
        public IEnumerable<ulong> removedPlayersIds;
        

public DungeonPartyFinderRoomContentUpdateMessage()
{
}

public DungeonPartyFinderRoomContentUpdateMessage(ushort dungeonId, IEnumerable<DungeonPartyFinderPlayer> addedPlayers, IEnumerable<ulong> removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(dungeonId);
            writer.WriteUShort((ushort)addedPlayers.Count());
            foreach (var entry in addedPlayers)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)removedPlayersIds.Count());
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteVarUhLong(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            addedPlayers = new DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 (addedPlayers as DungeonPartyFinderPlayer[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            removedPlayersIds = new ulong[limit];
            for (int i = 0; i < limit; i++)
            {
                 (removedPlayersIds as ulong[])[i] = reader.ReadVarUhLong();
            }
            

}


}


}