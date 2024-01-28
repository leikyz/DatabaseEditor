// Generated on 06/05/2015 03:00:11

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentRank", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentRank : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentRank";

        public uint descriptionId;

        public List<int> gifts;
        public int id;

        public int minimumAlignment;

        public uint nameId;

        public int objectsStolen;

        public uint orderId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint OrderId
        {
            get { return orderId; }

            set { orderId = value; }
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
        public int MinimumAlignment
        {
            get { return minimumAlignment; }

            set { minimumAlignment = value; }
        }

        [D2OIgnore]
        public int ObjectsStolen
        {
            get { return objectsStolen; }

            set { objectsStolen = value; }
        }

        [D2OIgnore]
        public List<int> Gifts
        {
            get { return gifts; }

            set { gifts = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}