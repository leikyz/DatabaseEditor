// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceDuration", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceDuration : EffectInstance
    {
        public uint days;

        public uint hours;

        public uint minutes;

        [D2OIgnore]
        public uint Days
        {
            get { return days; }

            set { days = value; }
        }

        [D2OIgnore]
        public uint Hours
        {
            get { return hours; }

            set { hours = value; }
        }

        [D2OIgnore]
        public uint Minutes
        {
            get { return minutes; }

            set { minutes = value; }
        }
    }
}