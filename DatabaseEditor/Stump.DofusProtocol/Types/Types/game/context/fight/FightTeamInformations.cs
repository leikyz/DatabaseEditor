



















// Generated on 04/20/2016 12:44:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class FightTeamInformations : AbstractFightTeamInformations
{

public const short Id = 33;
public override short TypeId
{
    get { return Id; }
}

public IEnumerable<Types.FightTeamMemberInformations> teamMembers;
        

public FightTeamInformations()
{
}

public FightTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, IEnumerable<Types.FightTeamMemberInformations> teamMembers)
         : base(teamId, leaderId, teamSide, teamTypeId, nbWaves)
        {
            this.teamMembers = teamMembers;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)teamMembers.Count());
            foreach (var entry in teamMembers)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            teamMembers = new Types.FightTeamMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (teamMembers as Types.FightTeamMemberInformations[])[i] = ProtocolTypeManager.GetInstance<Types.FightTeamMemberInformations>(reader.ReadShort());
                 (teamMembers as Types.FightTeamMemberInformations[])[i].Deserialize(reader);
            }
            

}


}


}