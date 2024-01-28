// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("TaxCollectorFirstnames", "com.ankamagames.dofus.datacenter.npcs", true)]
    public class TaxCollectorFirstname : IDataObject, IIndexedData
    {
        public const string MODULE = "TaxCollectorFirstnames";

        public uint firstnameId;
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint FirstnameId
        {
            get { return firstnameId; }

            set { firstnameId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}