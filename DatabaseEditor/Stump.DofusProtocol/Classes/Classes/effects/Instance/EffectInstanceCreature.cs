// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceCreature", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceCreature : EffectInstance
    {
        public uint monsterFamilyId;

        public int Id => (int) monsterFamilyId;

        [D2OIgnore]
        public uint MonsterFamilyId
        {
            get { return monsterFamilyId; }

            set { monsterFamilyId = value; }
        }
    }
}