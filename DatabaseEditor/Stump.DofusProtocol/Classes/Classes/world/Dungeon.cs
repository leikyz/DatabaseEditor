// Generated on 06/05/2015 03:00:23

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Dungeons", "com.ankamagames.dofus.datacenter.world", true)]
    public class Dungeon : IDataObject, IIndexedData
    {
        public const string MODULE = "Dungeons";

        public int entranceMapId;

        public int exitMapId;
        public int id;

        public List<int> mapIds;

        public uint nameId;

        public int optimalPlayerLevel;

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
        public int OptimalPlayerLevel
        {
            get { return optimalPlayerLevel; }

            set { optimalPlayerLevel = value; }
        }

        [D2OIgnore]
        public List<int> MapIds
        {
            get { return mapIds; }

            set { mapIds = value; }
        }

        [D2OIgnore]
        public int EntranceMapId
        {
            get { return entranceMapId; }

            set { entranceMapId = value; }
        }

        [D2OIgnore]
        public int ExitMapId
        {
            get { return exitMapId; }

            set { exitMapId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}