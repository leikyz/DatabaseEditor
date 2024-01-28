// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstance", "com.ankamagames.dofus.datacenter.effects"), Serializable]
    public class EffectInstance : IDataObject, IIndexedData
    {
        public int delay;

        public int duration;

        public uint effectId;

        public uint effectUid;

        public int group;

        public int modificator;

        public int random;

        public string rawZone;

        public bool rawZoneInit;

        public int targetId;

        public string targetMask;

        public bool trigger;

        public string triggers;

        public bool visibleInBuffUi;


        public bool visibleInFightLog = true;

        public bool visibleInTooltip;

        public uint zoneEfficiencyPercent;

        public uint zoneMaxEfficiency;

        public uint zoneMinSize;


        public uint zoneShape;


        public uint zoneSize;

        [D2OIgnore]
        public uint EffectUid
        {
            get { return effectUid; }

            set { effectUid = value; }
        }

        [D2OIgnore]
        public uint EffectId
        {
            get { return effectId; }

            set { effectId = value; }
        }

        [D2OIgnore]
        public int TargetId
        {
            get { return targetId; }

            set { targetId = value; }
        }

        [D2OIgnore]
        public string TargetMask
        {
            get { return targetMask; }

            set { targetMask = value; }
        }

        [D2OIgnore]
        public int Duration
        {
            get { return duration; }

            set { duration = value; }
        }

        [D2OIgnore]
        public int Delay
        {
            get { return delay; }

            set { delay = value; }
        }

        [D2OIgnore]
        public int Random
        {
            get { return random; }

            set { random = value; }
        }

        [D2OIgnore]
        public int Group
        {
            get { return group; }

            set { group = value; }
        }

        [D2OIgnore]
        public int Modificator
        {
            get { return modificator; }

            set { modificator = value; }
        }

        [D2OIgnore]
        public bool Trigger
        {
            get { return trigger; }

            set { trigger = value; }
        }

        [D2OIgnore]
        public string Triggers
        {
            get { return triggers; }

            set { triggers = value; }
        }

        [D2OIgnore]
        public bool VisibleInTooltip
        {
            get { return visibleInTooltip; }

            set { visibleInTooltip = value; }
        }

        [D2OIgnore]
        public bool VisibleInBuffUi
        {
            get { return visibleInBuffUi; }

            set { visibleInBuffUi = value; }
        }

        [D2OIgnore]
        public bool VisibleInFightLog
        {
            get { return visibleInFightLog; }

            set { visibleInFightLog = value; }
        }

        [D2OIgnore]
        public uint ZoneSize
        {
            get { return zoneSize; }

            set { zoneSize = value; }
        }

        [D2OIgnore]
        public uint ZoneShape
        {
            get { return zoneShape; }

            set { zoneShape = value; }
        }

        [D2OIgnore]
        public uint ZoneMinSize
        {
            get { return zoneMinSize; }

            set { zoneMinSize = value; }
        }

        [D2OIgnore]
        public uint ZoneEfficiencyPercent
        {
            get { return zoneEfficiencyPercent; }

            set { zoneEfficiencyPercent = value; }
        }

        [D2OIgnore]
        public uint ZoneMaxEfficiency
        {
            get { return zoneMaxEfficiency; }

            set { zoneMaxEfficiency = value; }
        }

        [D2OIgnore]
        public bool RawZoneInit
        {
            get { return rawZoneInit; }

            set { rawZoneInit = value; }
        }

        [D2OIgnore]
        public string RawZone
        {
            get { return rawZone; }

            set { rawZone = value; }
        }

        int IIndexedData.Id => (int) effectUid;
    }
}