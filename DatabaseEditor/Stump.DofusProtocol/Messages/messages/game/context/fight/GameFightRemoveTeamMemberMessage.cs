



















// Generated on 04/20/2016 12:03:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightRemoveTeamMemberMessage : Message
{

public const ushort Id = 711;
public override ushort MessageId
{
    get { return Id; }
}

public short fightId;
        public sbyte teamId;
        public double charId;
        

public GameFightRemoveTeamMemberMessage()
{
}

public GameFightRemoveTeamMemberMessage(short fightId, sbyte teamId, double charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(fightId);
            writer.WriteSByte(teamId);
            writer.WriteDouble(charId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            charId = reader.ReadDouble();
            if (charId < -9.007199254740992E15 || charId > 9.007199254740992E15)
                throw new Exception("Forbidden value on charId = " + charId + ", it doesn't respect the following condition : charId < -9.007199254740992E15 || charId > 9.007199254740992E15");
            

}


}


}