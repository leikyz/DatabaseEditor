



















// Generated on 04/20/2016 12:03:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightSpectatorJoinMessage : GameFightJoinMessage
{

public const ushort Id = 6504;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<NamedPartyTeam> namedPartyTeams;
        

public GameFightSpectatorJoinMessage()
{
}

public GameFightSpectatorJoinMessage(bool isTeamPhase, bool canBeCancelled, bool canSayReady, bool isFightStarted, short timeMaxBeforeFightStart, sbyte fightType, IEnumerable<NamedPartyTeam> namedPartyTeams)
         : base(isTeamPhase, canBeCancelled, canSayReady, isFightStarted, timeMaxBeforeFightStart, fightType)
        {
            this.namedPartyTeams = namedPartyTeams;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)namedPartyTeams.Count());
            foreach (var entry in namedPartyTeams)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            namedPartyTeams = new NamedPartyTeam[limit];
            for (int i = 0; i < limit; i++)
            {
                 (namedPartyTeams as NamedPartyTeam[])[i].Deserialize(reader);
            }
            

}


}


}