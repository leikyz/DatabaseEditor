// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Appearances", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class Appearance : IDataObject, IIndexedData
    {
        public const string MODULE = "Appearances";

        public string data;
        public int id;

        public uint type;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint Type
        {
            get { return type; }

            set { type = value; }
        }

        [D2OIgnore]
        public string Data
        {
            get { return data; }

            set { data = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}