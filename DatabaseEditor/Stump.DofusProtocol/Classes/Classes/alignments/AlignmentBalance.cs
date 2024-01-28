// Generated on 06/05/2015 03:00:11

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentBalance", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentBalance : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentBalance";

        public uint descriptionId;

        public int endValue;
        public int id;

        public uint nameId;

        public int startValue;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int StartValue
        {
            get { return startValue; }

            set { startValue = value; }
        }

        [D2OIgnore]
        public int EndValue
        {
            get { return endValue; }

            set { endValue = value; }
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

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}