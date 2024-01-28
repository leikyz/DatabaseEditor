// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AchievementCategories", "com.ankamagames.dofus.datacenter.quest", true)]
    public class AchievementCategory : IDataObject, IIndexedData
    {
        public const string MODULE = "AchievementCategories";

        public List<uint> achievementIds;

        public string color;

        public string icon;
        public uint id;

        public uint nameId;

        public uint order;

        public uint parentId;

        [D2OIgnore]
        public uint Id
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
        public uint ParentId
        {
            get { return parentId; }

            set { parentId = value; }
        }

        [D2OIgnore]
        public string Icon
        {
            get { return icon; }

            set { icon = value; }
        }

        [D2OIgnore]
        public uint Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public string Color
        {
            get { return color; }

            set { color = value; }
        }

        [D2OIgnore]
        public List<uint> AchievementIds
        {
            get { return achievementIds; }

            set { achievementIds = value; }
        }

        int IIndexedData.Id
        {
            get { return (int)id; }
        }
    }
}