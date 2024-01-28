// Generated on 06/05/2015 03:00:14

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("RankNames", "com.ankamagames.dofus.datacenter.guild", true)]
    public class RankName : IDataObject, IIndexedData
    {
        public const string MODULE = "RankNames";
        public int id;

        public uint nameId;

        public int order;

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