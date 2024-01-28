// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Characteristics", "com.ankamagames.dofus.datacenter.characteristics", true)]
    public class Characteristic : IDataObject, IIndexedData
    {
        public const string MODULE = "Characteristics";

        public string asset;

        public int categoryId;
        public int id;

        public string keyword;

        public uint nameId;

        public int order;

        public bool upgradable;

        public bool visible;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string Keyword
        {
            get { return keyword; }

            set { keyword = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public string Asset
        {
            get { return asset; }

            set { asset = value; }
        }

        [D2OIgnore]
        public int CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        [D2OIgnore]
        public bool Visible
        {
            get { return visible; }

            set { visible = value; }
        }

        [D2OIgnore]
        public int Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public bool Upgradable
        {
            get { return upgradable; }

            set { upgradable = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}