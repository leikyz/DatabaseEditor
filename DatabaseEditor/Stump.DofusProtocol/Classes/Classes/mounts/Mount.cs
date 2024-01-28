// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Mounts", "com.ankamagames.dofus.datacenter.mounts", true)]
    public class Mount : IDataObject, IIndexedData
    {
        public int id;

        public string look;
        private string MODULE = "Mounts";

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

        [D2OIgnore]
        public string Look
        {
            get { return look; }

            set { look = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}