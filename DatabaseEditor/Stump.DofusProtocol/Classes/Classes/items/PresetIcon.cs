// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("PresetIcons", "com.ankamagames.dofus.datacenter.items", true)]
    public class PresetIcon : IDataObject, IIndexedData
    {
        public const string MODULE = "PresetIcons";
        public int id;

        public int order;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
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