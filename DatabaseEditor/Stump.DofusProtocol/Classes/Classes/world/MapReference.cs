// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MapReferences", "com.ankamagames.dofus.datacenter.world", true)]
    public class MapReference : IDataObject, IIndexedData
    {
        public const string MODULE = "MapReferences";

        public int cellId;
        public int id;

        public uint mapId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint MapId
        {
            get { return mapId; }

            set { mapId = value; }
        }

        [D2OIgnore]
        public int CellId
        {
            get { return cellId; }

            set { cellId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}