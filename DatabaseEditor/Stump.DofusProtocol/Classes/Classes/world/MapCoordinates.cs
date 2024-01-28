// Generated on 06/05/2015 03:00:23

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MapCoordinates", "com.ankamagames.dofus.datacenter.world", true)]
    public class MapCoordinates : IDataObject
    {
        public const string MODULE = "MapCoordinates";
        public uint compressedCoords;

        public List<int> mapIds;

        [D2OIgnore]
        public uint CompressedCoords
        {
            get { return compressedCoords; }

            set { compressedCoords = value; }
        }

        [D2OIgnore]
        public List<int> MapIds
        {
            get { return mapIds; }

            set { mapIds = value; }
        }
    }
}