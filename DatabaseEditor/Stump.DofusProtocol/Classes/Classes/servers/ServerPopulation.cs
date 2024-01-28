// Generated on 06/05/2015 03:00:22

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ServerPopulations", "com.ankamagames.dofus.datacenter.servers", true)]
    public class ServerPopulation : IDataObject, IIndexedData
    {
        public const string MODULE = "ServerPopulations";
        public int id;

        public uint nameId;

        public int weight;

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
        public int Weight
        {
            get { return weight; }

            set { weight = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}