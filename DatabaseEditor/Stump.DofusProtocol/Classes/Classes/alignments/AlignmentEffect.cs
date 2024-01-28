// Generated on 06/05/2015 03:00:11

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentEffect", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentEffect : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentEffect";

        public uint characteristicId;

        public uint descriptionId;
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint CharacteristicId
        {
            get { return characteristicId; }

            set { characteristicId = value; }
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