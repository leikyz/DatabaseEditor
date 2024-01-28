// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Phoenixes", "com.ankamagames.dofus.datacenter.world", true)]
    public class Phoenix : IDataObject, IIndexedData
    {
        public const string MODULE = "Phoenixes";
        public uint mapId;

        [D2OIgnore]
        public uint MapId
        {
            get { return mapId; }

            set { mapId = value; }
        }

        int IIndexedData.Id
        {
            get { return (int) mapId; }
        }
    }
}