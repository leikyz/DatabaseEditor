// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SuperAreas", "com.ankamagames.dofus.datacenter.world", true)]
    public class SuperArea : IDataObject, IIndexedData
    {
        public const string MODULE = "SuperAreas";

        public bool hasWorldMap;
        public int id;

        public uint nameId;

        public uint worldmapId;

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
        public uint WorldmapId
        {
            get { return worldmapId; }

            set { worldmapId = value; }
        }

        [D2OIgnore]
        public bool HasWorldMap
        {
            get { return hasWorldMap; }

            set { hasWorldMap = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}