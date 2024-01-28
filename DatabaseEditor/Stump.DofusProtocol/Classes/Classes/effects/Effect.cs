// Generated on 02/08/2015 21:50:02

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Effects", "com.ankamagames.dofus.datacenter.effects")]
    public class Effect : IDataObject, IIndexedData
    {
        public const string MODULE = "Effects";

        public bool active;

        public int bonusType;

        public bool boost;

        public uint category;

        public int characteristic;

        public uint descriptionId;

        public uint effectPriority;

        public int elementId;

        public bool forceMinMax;

        public int iconId;
        public int id;

        public string @operator;
        public int oppositeId;

        public bool showInSet;

        public bool showInTooltip;
        public uint theoreticalDescriptionId;

        public uint theoreticalPattern;

        public bool useDice;

        public bool useInFight;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public int Characteristic
        {
            get { return characteristic; }

            set { characteristic = value; }
        }

        [D2OIgnore]
        public uint Category
        {
            get { return category; }

            set { category = value; }
        }

        [D2OIgnore]
        public string Operator
        {
            get { return @operator; }

            set { @operator = value; }
        }

        [D2OIgnore]
        public bool ShowInTooltip
        {
            get { return showInTooltip; }

            set { showInTooltip = value; }
        }

        [D2OIgnore]
        public bool UseDice
        {
            get { return useDice; }

            set { useDice = value; }
        }

        [D2OIgnore]
        public bool ForceMinMax
        {
            get { return forceMinMax; }

            set { forceMinMax = value; }
        }

        [D2OIgnore]
        public bool Boost
        {
            get { return boost; }

            set { boost = value; }
        }

        [D2OIgnore]
        public bool Active
        {
            get { return active; }

            set { active = value; }
        }

        [D2OIgnore]
        public int OppositeId
        {
            get { return oppositeId; }

            set { oppositeId = value; }
        }

        [D2OIgnore]
        public uint TheoreticalDescriptionId
        {
            get { return theoreticalDescriptionId; }

            set { theoreticalDescriptionId = value; }
        }

        [D2OIgnore]
        public uint TheoreticalPattern
        {
            get { return theoreticalPattern; }

            set { theoreticalPattern = value; }
        }

        [D2OIgnore]
        public bool ShowInSet
        {
            get { return showInSet; }

            set { showInSet = value; }
        }

        [D2OIgnore]
        public int BonusType
        {
            get { return bonusType; }

            set { bonusType = value; }
        }

        [D2OIgnore]
        public bool UseInFight
        {
            get { return useInFight; }

            set { useInFight = value; }
        }

        [D2OIgnore]
        public uint EffectPriority
        {
            get { return effectPriority; }

            set { effectPriority = value; }
        }

        [D2OIgnore]
        public int ElementId
        {
            get { return elementId; }

            set { elementId = value; }
        }

        int IIndexedData.Id => id;
    }
}