// Generated on 06/05/2015 03:00:21

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("PointOfInterest", "com.ankamagames.dofus.datacenter.questOfInterest.as", true)]
    public class PointOfInterest : IDataObject, IIndexedData
    {
        public const string MODULE = "PointOfInterest";

        public uint categoryId;
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
        public uint CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}