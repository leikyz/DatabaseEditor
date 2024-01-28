// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Areas", "com.ankamagames.dofus.datacenter.world", true)]
    public class Area : IDataObject, IIndexedData
    {
        public const string MODULE = "Areas";

        public Rectangle bounds;

        public bool containHouses;

        public bool containPaddocks;

        public bool hasWorldMap;
        public int id;

        public uint nameId;

        public int superAreaId;

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
        public int SuperAreaId
        {
            get { return superAreaId; }

            set { superAreaId = value; }
        }

        [D2OIgnore]
        public bool ContainHouses
        {
            get { return containHouses; }

            set { containHouses = value; }
        }

        [D2OIgnore]
        public bool ContainPaddocks
        {
            get { return containPaddocks; }

            set { containPaddocks = value; }
        }

        [D2OIgnore]
        public Rectangle Bounds
        {
            get { return bounds; }

            set { bounds = value; }
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