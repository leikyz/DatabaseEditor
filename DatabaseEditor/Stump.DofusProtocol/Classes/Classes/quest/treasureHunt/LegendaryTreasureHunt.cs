// Generated on 06/05/2015 03:00:21

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("LegendaryTreasureHunts", "com.ankamagames.dofus.datacenter.questeasureHunt.as", true)]
    public class LegendaryTreasureHunt : IDataObject, IIndexedData
    {
        public const string MODULE = "LegendaryTreasureHunts";

        public uint chestId;
        public int id;

        public uint level;

        public uint mapItemId;

        public uint monsterId;

        public uint nameId;

        public float xpRatio;

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
        public uint Level
        {
            get { return level; }

            set { level = value; }
        }

        [D2OIgnore]
        public uint ChestId
        {
            get { return chestId; }

            set { chestId = value; }
        }

        [D2OIgnore]
        public uint MonsterId
        {
            get { return monsterId; }

            set { monsterId = value; }
        }

        [D2OIgnore]
        public uint MapItemId
        {
            get { return mapItemId; }

            set { mapItemId = value; }
        }

        [D2OIgnore]
        public float XpRatio
        {
            get { return xpRatio; }

            set { xpRatio = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}