// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentSides", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentSide : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentSides";

        public bool canConquest;
        public int id;

        public uint nameId;

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
        public bool CanConquest
        {
            get { return canConquest; }

            set { canConquest = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}