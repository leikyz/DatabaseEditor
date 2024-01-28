// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Quests", "com.ankamagames.dofus.datacenter.quest", true)]
    public class Quest : IDataObject, IIndexedData
    {
        public const string MODULE = "Quests";

        public uint categoryId;
        public int id;

        public bool isDungeonQuest;

        public bool isPartyQuest;

        public bool isRepeatable;

        public uint levelMax;

        public uint levelMin;

        public uint nameId;

        public uint repeatLimit;

        public uint repeatType;

        public List<uint> stepIds;

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
        public List<uint> StepIds
        {
            get { return stepIds; }

            set { stepIds = value; }
        }

        [D2OIgnore]
        public uint CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        [D2OIgnore]
        public bool IsRepeatable
        {
            get { return isRepeatable; }

            set { isRepeatable = value; }
        }

        [D2OIgnore]
        public uint RepeatType
        {
            get { return repeatType; }

            set { repeatType = value; }
        }

        [D2OIgnore]
        public uint RepeatLimit
        {
            get { return repeatLimit; }

            set { repeatLimit = value; }
        }

        [D2OIgnore]
        public bool IsDungeonQuest
        {
            get { return isDungeonQuest; }

            set { isDungeonQuest = value; }
        }

        [D2OIgnore]
        public uint LevelMin
        {
            get { return levelMin; }

            set { levelMin = value; }
        }

        [D2OIgnore]
        public uint LevelMax
        {
            get { return levelMax; }

            set { levelMax = value; }
        }

        [D2OIgnore]
        public bool IsPartyQuest
        {
            get { return isPartyQuest; }

            set { isPartyQuest = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}