



















// Generated on 04/20/2016 12:04:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildFightPlayersHelpersJoinMessage : Message
{

public const ushort Id = 5720;
public override ushort MessageId
{
    get { return Id; }
}

public int fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        

public GuildFightPlayersHelpersJoinMessage()
{
}

public GuildFightPlayersHelpersJoinMessage(int fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(fightId);
            playerInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
            

}


}


}