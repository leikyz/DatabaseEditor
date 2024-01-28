// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AchievementRewards", "com.ankamagames.dofus.datacenter.quest", true)]
    public class AchievementReward : IDataObject, IIndexedData
    {
        public const string MODULE = "AchievementRewards";

        public uint achievementId;

        public List<uint> emotesReward;
        public int id;

        public List<uint> itemsQuantityReward;

        public List<uint> itemsReward;

        public int levelMax;

        public int levelMin;

        public List<uint> ornamentsReward;

        public List<uint> spellsReward;

        public List<uint> titlesReward;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint AchievementId
        {
            get { return achievementId; }

            set { achievementId = value; }
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
        public List<uint> ItemsReward
        {
            get { return itemsReward; }

            set { itemsReward = value; }
        }

        [D2OIgnore]
        public List<uint> ItemsQuantityReward
        {
            get { return itemsQuantityReward; }

            set { itemsQuantityReward = value; }
        }

        [D2OIgnore]
        public List<uint> EmotesReward
        {
            get { return emotesReward; }

            set { emotesReward = value; }
        }

        [D2OIgnore]
        public List<uint> SpellsReward
        {
            get { return spellsReward; }

            set { spellsReward = value; }
        }

        [D2OIgnore]
        public List<uint> TitlesReward
        {
            get { return titlesReward; }

            set { titlesReward = value; }
        }

        [D2OIgnore]
        public List<uint> OrnamentsReward
        {
            get { return ornamentsReward; }

            set { ornamentsReward = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}