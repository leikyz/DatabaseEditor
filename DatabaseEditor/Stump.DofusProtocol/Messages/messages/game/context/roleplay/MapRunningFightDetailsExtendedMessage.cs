



















// Generated on 04/20/2016 12:03:32
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MapRunningFightDetailsExtendedMessage : MapRunningFightDetailsMessage
{

public const ushort Id = 6500;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<NamedPartyTeam> namedPartyTeams;
        

public MapRunningFightDetailsExtendedMessage()
{
}

public MapRunningFightDetailsExtendedMessage(int fightId, IEnumerable<Types.GameFightFighterLightInformations> attackers, IEnumerable<Types.GameFightFighterLightInformations> defenders, IEnumerable<NamedPartyTeam> namedPartyTeams)
         : base(fightId, attackers, defenders)
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