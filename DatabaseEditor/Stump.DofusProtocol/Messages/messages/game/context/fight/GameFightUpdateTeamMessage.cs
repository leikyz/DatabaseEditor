



















// Generated on 04/20/2016 12:03:27
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightUpdateTeamMessage : Message
{

public const ushort Id = 5572;
public override ushort MessageId
{
    get { return Id; }
}

public short fightId;
        public Types.FightTeamInformations team;
        

public GameFightUpdateTeamMessage()
{
}

public GameFightUpdateTeamMessage(short fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(fightId);
            team.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
            

}


}


}