// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceInteger", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceInteger : EffectInstance
    {
        public int value;

        [D2OIgnore]
        public int Value
        {
            get { return value; }

            set { this.value = value; }
        }
    }
}