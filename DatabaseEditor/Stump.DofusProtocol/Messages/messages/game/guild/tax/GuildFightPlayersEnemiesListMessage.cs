



















// Generated on 04/20/2016 12:04:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildFightPlayersEnemiesListMessage : Message
{

public const ushort Id = 5928;
public override ushort MessageId
{
    get { return Id; }
}

public int fightId;
        public IEnumerable<CharacterMinimalPlusLookInformations> playerInfo;
        

public GuildFightPlayersEnemiesListMessage()
{
}

public GuildFightPlayersEnemiesListMessage(int fightId, IEnumerable<CharacterMinimalPlusLookInformations> playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(fightId);
            writer.WriteUShort((ushort)playerInfo.Count());
            foreach (var entry in playerInfo)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            var limit = reader.ReadUShort();
            playerInfo = new CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (playerInfo as CharacterMinimalPlusLookInformations[])[i].Deserialize(reader);
            }
            

}


}


}