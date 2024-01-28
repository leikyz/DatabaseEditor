// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceLadder", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceLadder : EffectInstanceCreature
    {
        public uint monsterCount;

        [D2OIgnore]
        public uint MonsterCount
        {
            get { return monsterCount; }

            set { monsterCount = value; }
        }
    }
}