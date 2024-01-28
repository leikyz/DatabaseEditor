// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Hints", "com.ankamagames.dofus.datacenter.world", true)]
    public class Hint : IDataObject, IIndexedData
    {
        public const string MODULE = "Hints";

        public uint categoryId;

        public uint gfx;
        public int id;

        public uint mapId;

        public uint nameId;

        public bool outdoor;

        public uint realMapId;

        public int subareaId;

        public int worldMapId;

        public int x;

        public int y;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        [D2OIgnore]
        public uint Gfx
        {
            get { return gfx; }

            set { gfx = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public uint MapId
        {
            get { return mapId; }

            set { mapId = value; }
        }

        [D2OIgnore]
        public uint RealMapId
        {
            get { return realMapId; }

            set { realMapId = value; }
        }

        [D2OIgnore]
        public int X
        {
            get { return x; }

            set { x = value; }
        }

        [D2OIgnore]
        public int Y
        {
            get { return y; }

            set { y = value; }
        }

        [D2OIgnore]
        public bool Outdoor
        {
            get { return outdoor; }

            set { outdoor = value; }
        }

        [D2OIgnore]
        public int SubareaId
        {
            get { return subareaId; }

            set { subareaId = value; }
        }

        [D2OIgnore]
        public int WorldMapId
        {
            get { return worldMapId; }

            set { worldMapId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}