// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Months", "com.ankamagames.dofus.datacenter.misc", true)]
    public class Month : IDataObject, IIndexedData
    {
        public const string MODULE = "Months";
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

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}