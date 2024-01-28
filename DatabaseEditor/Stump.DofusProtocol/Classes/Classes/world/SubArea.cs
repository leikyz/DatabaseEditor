// Generated on 06/05/2015 03:00:23

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SubAreas", "com.ankamagames.dofus.datacenter.world", true)]
    public class SubArea : IDataObject, IIndexedData
    {
        public const string MODULE = "SubAreas";

        public List<AmbientSound> ambientSounds;

        public int areaId;

        public bool basicAccountAllowed;

        public Rectangle bounds;

        public bool capturable;

        public List<uint> customWorldMap;

        public bool displayOnWorldMap;

        public List<uint> entranceMapIds;

        public List<uint> exitMapIds;
        public int id;

        public bool isConquestVillage;

        public uint level;

        public List<uint> mapIds;

        public List<uint> monsters;

        public uint nameId;

        public int packId;

        public List<List<int>> playlists;

        public List<int> shape;

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
        public int AreaId
        {
            get { return areaId; }

            set { areaId = value; }
        }

        [D2OIgnore]
        public List<AmbientSound> AmbientSounds
        {
            get { return ambientSounds; }

            set { ambientSounds = value; }
        }

        [D2OIgnore]
        public List<List<int>> Playlists
        {
            get { return playlists; }

            set { playlists = value; }
        }

        [D2OIgnore]
        public List<uint> MapIds
        {
            get { return mapIds; }

            set { mapIds = value; }
        }

        [D2OIgnore]
        public Rectangle Bounds
        {
            get { return bounds; }

            set { bounds = value; }
        }

        [D2OIgnore]
        public List<int> Shape
        {
            get { return shape; }

            set { shape = value; }
        }

        [D2OIgnore]
        public List<uint> CustomWorldMap
        {
            get { return customWorldMap; }

            set { customWorldMap = value; }
        }

        [D2OIgnore]
        public int PackId
        {
            get { return packId; }

            set { packId = value; }
        }

        [D2OIgnore]
        public uint Level
        {
            get { return level; }

            set { level = value; }
        }

        [D2OIgnore]
        public bool IsConquestVillage
        {
            get { return isConquestVillage; }

            set { isConquestVillage = value; }
        }

        [D2OIgnore]
        public bool BasicAccountAllowed
        {
            get { return basicAccountAllowed; }

            set { basicAccountAllowed = value; }
        }

        [D2OIgnore]
        public bool DisplayOnWorldMap
        {
            get { return displayOnWorldMap; }

            set { displayOnWorldMap = value; }
        }

        [D2OIgnore]
        public List<uint> Monsters
        {
            get { return monsters; }

            set { monsters = value; }
        }

        [D2OIgnore]
        public List<uint> EntranceMapIds
        {
            get { return entranceMapIds; }

            set { entranceMapIds = value; }
        }

        [D2OIgnore]
        public List<uint> ExitMapIds
        {
            get { return exitMapIds; }

            set { exitMapIds = value; }
        }

        [D2OIgnore]
        public bool Capturable
        {
            get { return capturable; }

            set { capturable = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}