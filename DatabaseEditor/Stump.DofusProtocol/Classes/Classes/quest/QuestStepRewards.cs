// Generated on 06/05/2015 03:00:21

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("QuestStepRewards", "com.ankamagames.dofus.datacenter.quest", true)]
    public class QuestStepRewards : IDataObject, IIndexedData
    {
        public const string MODULE = "QuestStepRewards";

        public List<uint> emotesReward;
        public int id;

        public List<List<uint>> itemsReward;

        public List<uint> jobsReward;

        public int levelMax;

        public int levelMin;

        public List<uint> spellsReward;

        public uint stepId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint StepId
        {
            get { return stepId; }

            set { stepId = value; }
        }

        [D2OIgnore]
        public int LevelMin
        {
            get { return levelMin; }

            set { levelMin = value; }
        }

        [D2OIgnore]
        public int LevelMax
        {
            get { return levelMax; }

            set { levelMax = value; }
        }

        [D2OIgnore]
        public List<List<uint>> ItemsReward
        {
            get { return itemsReward; }

            set { itemsReward = value; }
        }

        [D2OIgnore]
        public List<uint> EmotesReward
        {
            get { return emotesReward; }

            set { emotesReward = value; }
        }

        [D2OIgnore]
        public List<uint> JobsReward
        {
            get { return jobsReward; }

            set { jobsReward = value; }
        }

        [D2OIgnore]
        public List<uint> SpellsReward
        {
            get { return spellsReward; }

            set { spellsReward = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}