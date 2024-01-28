// Generated on 06/05/2015 03:00:23

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MapPositions", "com.ankamagames.dofus.datacenter.world", true)]
    public class MapPosition : IDataObject, IIndexedData
    {
        public const string MODULE = "MapPositions";

        public int capabilities;

        public bool hasPriorityOnWorldmap;
        public int id;

        public int nameId;

        public bool outdoor;

        public List<List<int>> playlists;

        public int posX;

        public int posY;

        public bool showNameOnFingerpost;

        public List<AmbientSound> sounds;

        public int subAreaId;

        public int worldMap;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int PosX
        {
            get { return posX; }

            set { posX = value; }
        }

        [D2OIgnore]
        public int PosY
        {
            get { return posY; }

            set { posY = value; }
        }

        [D2OIgnore]
        public bool Outdoor
        {
            get { return outdoor; }

            set { outdoor = value; }
        }

        [D2OIgnore]
        public int Capabilities
        {
            get { return capabilities; }

            set { capabilities = value; }
        }

        [D2OIgnore]
        public int NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public bool ShowNameOnFingerpost
        {
            get { return showNameOnFingerpost; }

            set { showNameOnFingerpost = value; }
        }

        [D2OIgnore]
        public List<AmbientSound> Sounds
        {
            get { return sounds; }

            set { sounds = value; }
        }

        [D2OIgnore]
        public List<List<int>> Playlists
        {
            get { return playlists; }

            set { playlists = value; }
        }

        [D2OIgnore]
        public int SubAreaId
        {
            get { return subAreaId; }

            set { subAreaId = value; }
        }

        [D2OIgnore]
        public int WorldMap
        {
            get { return worldMap; }

            set { worldMap = value; }
        }

        [D2OIgnore]
        public bool HasPriorityOnWorldmap
        {
            get { return hasPriorityOnWorldmap; }

            set { hasPriorityOnWorldmap = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}