



















// Generated on 04/20/2016 12:03:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightEndMessage : Message
{

public const ushort Id = 720;
public override ushort MessageId
{
    get { return Id; }
}

public int duration;
        public short ageBonus;
        public short lootShareLimitMalus;
        public IEnumerable<Types.FightResultListEntry> results;
        public IEnumerable<NamedPartyTeamWithOutcome> namedPartyTeamsOutcomes;
        

public GameFightEndMessage()
{
}

public GameFightEndMessage(int duration, short ageBonus, short lootShareLimitMalus, IEnumerable<Types.FightResultListEntry> results, IEnumerable<NamedPartyTeamWithOutcome> namedPartyTeamsOutcomes)
        {
            this.duration = duration;
            this.ageBonus = ageBonus;
            this.lootShareLimitMalus = lootShareLimitMalus;
            this.results = results;
            this.namedPartyTeamsOutcomes = namedPartyTeamsOutcomes;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(duration);
            writer.WriteShort(ageBonus);
            writer.WriteShort(lootShareLimitMalus);
            writer.WriteUShort((ushort)results.Count());
            foreach (var entry in results)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)namedPartyTeamsOutcomes.Count());
            foreach (var entry in namedPartyTeamsOutcomes)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

duration = reader.ReadInt();
            if (duration < 0)
                throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
            ageBonus = reader.ReadShort();
            lootShareLimitMalus = reader.ReadShort();
            var limit = reader.ReadUShort();
            results = new Types.FightResultListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 (results as Types.FightResultListEntry[])[i] = ProtocolTypeManager.GetInstance<Types.FightResultListEntry>(reader.ReadShort());
                 (results as Types.FightResultListEntry[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            namedPartyTeamsOutcomes = new NamedPartyTeamWithOutcome[limit];
            for (int i = 0; i < limit; i++)
            {
                 (namedPartyTeamsOutcomes as NamedPartyTeamWithOutcome[])[i].Deserialize(reader);
            }
            

}


}


}