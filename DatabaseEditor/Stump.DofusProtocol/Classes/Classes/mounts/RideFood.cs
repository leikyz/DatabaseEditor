// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("RideFood", "com.ankamagames.dofus.datacenter.mounts", true)]
    public class RideFood : IDataObject, IIndexedData
    {
        public uint gid;
        public string MODULE = "RideFood";

        public uint typeId;

        [D2OIgnore]
        public uint Gid
        {
            get { return gid; }

            set { gid = value; }
        }

        [D2OIgnore]
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        int IIndexedData.Id
        {
            get { return (int) gid; }
        }
    }
}