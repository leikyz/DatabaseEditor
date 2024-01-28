// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("BreedRoles", "com.ankamagames.dofus.datacenter.breeds", true)]
    public class BreedRole : IDataObject, IIndexedData
    {
        public const string MODULE = "BreedRoles";

        public int assetId;

        public int color;

        public uint descriptionId;
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
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public int AssetId
        {
            get { return assetId; }

            set { assetId = value; }
        }

        [D2OIgnore]
        public int Color
        {
            get { return color; }

            set { color = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}