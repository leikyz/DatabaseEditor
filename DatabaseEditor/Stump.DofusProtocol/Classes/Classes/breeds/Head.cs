// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Heads", "com.ankamagames.dofus.datacenter.breeds", true)]
    public class Head : IDataObject, IIndexedData
    {
        public const string MODULE = "Heads";

        public string assetId;

        public uint breed;

        public uint gender;
        public int id;

        public string label;

        public uint order;

        public string skins;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string Skins
        {
            get { return skins; }

            set { skins = value; }
        }

        [D2OIgnore]
        public string AssetId
        {
            get { return assetId; }

            set { assetId = value; }
        }

        [D2OIgnore]
        public uint Breed
        {
            get { return breed; }

            set { breed = value; }
        }

        [D2OIgnore]
        public uint Gender
        {
            get { return gender; }

            set { gender = value; }
        }

        [D2OIgnore]
        public string Label
        {
            get { return label; }

            set { label = value; }
        }

        [D2OIgnore]
        public uint Order
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