// Generated on 06/05/2015 03:00:21

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("QuestSteps", "com.ankamagames.dofus.datacenter.quest", true)]
    public class QuestStep : IDataObject, IIndexedData
    {
        public const string MODULE = "QuestSteps";

        public uint descriptionId;

        public int dialogId;

        public float duration;
        public int id;

        public float kamasRatio;

        public bool kamasScaleWithPlayerLevel;

        public uint nameId;

        public List<uint> objectiveIds;

        public uint optimalLevel;

        public uint questId;

        public List<uint> rewardsIds;

        public float xpRatio;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint QuestId
        {
            get { return questId; }

            set { questId = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public int DialogId
        {
            get { return dialogId; }

            set { dialogId = value; }
        }

        [D2OIgnore]
        public uint OptimalLevel
        {
            get { return optimalLevel; }

            set { optimalLevel = value; }
        }

        [D2OIgnore]
        public float Duration
        {
            get { return duration; }

            set { duration = value; }
        }

        [D2OIgnore]
        public bool KamasScaleWithPlayerLevel
        {
            get { return kamasScaleWithPlayerLevel; }

            set { kamasScaleWithPlayerLevel = value; }
        }

        [D2OIgnore]
        public float KamasRatio
        {
            get { return kamasRatio; }

            set { kamasRatio = value; }
        }

        [D2OIgnore]
        public float XpRatio
        {
            get { return xpRatio; }

            set { xpRatio = value; }
        }

        [D2OIgnore]
        public List<uint> ObjectiveIds
        {
            get { return objectiveIds; }

            set { objectiveIds = value; }
        }

        [D2OIgnore]
        public List<uint> RewardsIds
        {
            get { return rewardsIds; }

            set { rewardsIds = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}