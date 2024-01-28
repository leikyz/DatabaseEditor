



















// Generated on 04/20/2016 12:03:35
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosWithTeamMessage : GameRolePlayArenaUpdatePlayerInfosMessage
{

public const ushort Id = 6640;
public override ushort MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos team;
        

public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage(Types.ArenaRankInfos solo, Types.ArenaRankInfos team)
         : base(solo)
        {
            this.team = team;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            team.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            team = new Types.ArenaRankInfos();
            team.Deserialize(reader);
            

}


}


}