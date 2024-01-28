// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceMinMax", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceMinMax : EffectInstance
    {
        public uint max;
        public uint min;

        [D2OIgnore]
        public uint Min
        {
            get { return min; }

            set { min = value; }
        }

        [D2OIgnore]
        public uint Max
        {
            get { return max; }

            set { max = value; }
        }
    }
}