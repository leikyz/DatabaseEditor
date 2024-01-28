// Generated on 06/05/2015 03:00:14

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EmblemSymbols", "com.ankamagames.dofus.datacenter.guild", true)]
    public class EmblemSymbol : IDataObject, IIndexedData
    {
        public const string MODULE = "EmblemSymbols";

        public int categoryId;

        public bool colorizable;

        public int iconId;
        public int id;

        public int order;

        public int skinId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public int SkinId
        {
            get { return skinId; }

            set { skinId = value; }
        }

        [D2OIgnore]
        public int Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public int CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        [D2OIgnore]
        public bool Colorizable
        {
            get { return colorizable; }

            set { colorizable = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}