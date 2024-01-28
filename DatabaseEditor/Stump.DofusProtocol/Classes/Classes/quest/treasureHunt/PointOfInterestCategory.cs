// Generated on 06/05/2015 03:00:22

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("PointOfInterestCategory", "com.ankamagames.dofus.datacenter.queststCategory.as", true)]
    public class PointOfInterestCategory : IDataObject, IIndexedData
    {
        public const string MODULE = "PointOfInterestCategory";

        public uint actionLabelId;
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint ActionLabelId
        {
            get { return actionLabelId; }

            set { actionLabelId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}