// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Ornaments", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class Ornament : IDataObject, IIndexedData
    {
        public const string MODULE = "Ornaments";

        public int assetId;

        public int iconId;
        public int id;

        public uint nameId;

        public int order;

        public int rarity;

        public bool visible;

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
        public bool Visible
        {
            get { return visible; }

            set { visible = value; }
        }

        [D2OIgnore]
        public int AssetId
        {
            get { return assetId; }

            set { assetId = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public int Rarity
        {
            get { return rarity; }

            set { rarity = value; }
        }

        [D2OIgnore]
        public int Order
        {
            get { return order; }

            set { order = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}