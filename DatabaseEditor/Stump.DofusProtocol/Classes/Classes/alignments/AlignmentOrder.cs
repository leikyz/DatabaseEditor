// Generated on 06/05/2015 03:00:11

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentOrder", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentOrder : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentOrder";
        public int id;

        public uint nameId;

        public uint sideId;

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
        public uint SideId
        {
            get { return sideId; }

            set { sideId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}