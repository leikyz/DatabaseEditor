// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("QuestCategory", "com.ankamagames.dofus.datacenter.quest", true)]
    public class QuestCategory : IDataObject, IIndexedData
    {
        public const string MODULE = "QuestCategory";
        public int id;

        public uint nameId;

        public uint order;

        public List<uint> questIds;

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
        public uint Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public List<uint> QuestIds
        {
            get { return questIds; }

            set { questIds = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}