// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("NpcActions", "com.ankamagames.dofus.datacenter.npcs", true)]
    public class NpcAction : IDataObject, IIndexedData
    {
        public const string MODULE = "NpcActions";
        public int id;

        public uint nameId;

        public int realId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int RealId
        {
            get { return realId; }

            set { realId = value; }
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