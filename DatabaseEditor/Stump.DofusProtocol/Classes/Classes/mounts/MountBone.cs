// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MountBones", "com.ankamagames.dofus.datacenter.mounts", true)]
    public class MountBone : IDataObject, IIndexedData
    {
        public int id;
        private string MODULE = "MountBones";

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}