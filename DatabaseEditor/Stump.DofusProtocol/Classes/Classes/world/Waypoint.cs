// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Waypoints", "com.ankamagames.dofus.datacenter.world", true)]
    public class Waypoint : IDataObject, IIndexedData
    {
        public const string MODULE = "Waypoints";
        public int id;

        public uint mapId;

        public uint subAreaId;

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
        public uint SubAreaId
        {
            get { return subAreaId; }

            set { subAreaId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}