// Generated on 06/05/2015 03:00:14

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Houses", "com.ankamagames.dofus.datacenter.houses", true)]
    public class House : IDataObject, IIndexedData
    {
        public const string MODULE = "Houses";

        public uint defaultPrice;

        public int descriptionId;

        public int gfxId;

        public int nameId;
        public int typeId;

        [D2OIgnore]
        public int TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public uint DefaultPrice
        {
            get { return defaultPrice; }

            set { defaultPrice = value; }
        }

        [D2OIgnore]
        public int NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public int DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public int GfxId
        {
            get { return gfxId; }

            set { gfxId = value; }
        }

        int IIndexedData.Id
        {
            get { return typeId; }
        }
    }
}