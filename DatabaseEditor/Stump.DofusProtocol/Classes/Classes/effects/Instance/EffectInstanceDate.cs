// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceDate", "com.ankamagames.dofus.datacenter.effects.instances", true), Serializable]
    public class EffectInstanceDate : EffectInstance
    {
        public uint day;

        public uint hour;

        public uint minute;

        public uint month;

        public uint year;

        [D2OIgnore]
        public uint Year
        {
            get { return year; }

            set { year = value; }
        }

        [D2OIgnore]
        public uint Month
        {
            get { return month; }

            set { month = value; }
        }

        [D2OIgnore]
        public uint Day
        {
            get { return day; }

            set { day = value; }
        }

        [D2OIgnore]
        public uint Hour
        {
            get { return hour; }

            set { hour = value; }
        }

        [D2OIgnore]
        public uint Minute
        {
            get { return minute; }

            set { minute = value; }
        }
    }
}