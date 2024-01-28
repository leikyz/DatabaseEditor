// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Comics", "com.ankamagames.dofus.datacenter.documents", true)]
    public class Comic : IDataObject, IIndexedData
    {
        private const string MODULE = "Comics";
        public int id;

        public string remoteId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string RemoteId
        {
            get { return remoteId; }

            set { remoteId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}