// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Achievements", "com.ankamagames.dofus.datacenter.quest", true)]
    public class Achievement : IDataObject, IIndexedData
    {
        public const string MODULE = "Achievements";

        public uint categoryId;

        public uint descriptionId;

        public float experienceRatio;

        public int iconId;
        public int id;

        public float kamasRatio;

        public bool kamasScaleWithPlayerLevel;

        public uint level;

        public uint nameId;

        public List<int> objectiveIds;

        public uint order;

        public uint points;

        public List<int> rewardIds;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public uint CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
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
        public uint Points
        {
            get { return points; }

            set { points = value; }
        }

        [D2OIgnore]
        public uint Level
        {
            get { return level; }

            set { level = value; }
        }

        [D2OIgnore]
        public uint Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public float KamasRatio
        {
            get { return kamasRatio; }

            set { kamasRatio = value; }
        }

        [D2OIgnore]
        public float ExperienceRatio
        {
            get { return experienceRatio; }

            set { experienceRatio = value; }
        }

        [D2OIgnore]
        public bool KamasScaleWithPlayerLevel
        {
            get { return kamasScaleWithPlayerLevel; }

            set { kamasScaleWithPlayerLevel = value; }
        }

        [D2OIgnore]
        public List<int> ObjectiveIds
        {
            get { return objectiveIds; }

            set { objectiveIds = value; }
        }

        [D2OIgnore]
        public List<int> RewardIds
        {
            get { return rewardIds; }

            set { rewardIds = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}