



















// Generated on 04/20/2016 12:44:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
{

public const short Id = 464;
public override short TypeId
{
    get { return Id; }
}

public sbyte nbWaves;
        public IEnumerable<Types.GroupMonsterStaticInformations> alternatives;
        

public GameRolePlayGroupMonsterWaveInformations()
{
}

public GameRolePlayGroupMonsterWaveInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, Types.GroupMonsterStaticInformations staticInfos, double creationTime, int ageBonusRate, sbyte lootShare, sbyte alignmentSide, sbyte nbWaves, IEnumerable<Types.GroupMonsterStaticInformations> alternatives)
         : base(contextualId, look, disposition, keyRingBonus, hasHardcoreDrop, hasAVARewardToken, staticInfos, creationTime, ageBonusRate, lootShare, alignmentSide)
        {
            this.nbWaves = nbWaves;
            this.alternatives = alternatives;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteSByte(nbWaves);
            writer.WriteUShort((ushort)alternatives.Count());
            foreach (var entry in alternatives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            nbWaves = reader.ReadSByte();
            if (nbWaves < 0)
                throw new Exception("Forbidden value on nbWaves = " + nbWaves + ", it doesn't respect the following condition : nbWaves < 0");
            var limit = reader.ReadUShort();
            alternatives = new Types.GroupMonsterStaticInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alternatives as Types.GroupMonsterStaticInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GroupMonsterStaticInformations>(reader.ReadShort());
                 (alternatives as Types.GroupMonsterStaticInformations[])[i].Deserialize(reader);
            }
            

}


}


}