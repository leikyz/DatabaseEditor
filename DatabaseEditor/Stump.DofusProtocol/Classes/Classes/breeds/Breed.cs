// Generated on 06/05/2015 03:00:12

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Breeds", "com.ankamagames.dofus.datacenter.breeds", true)]
    public class Breed : IDataObject, IIndexedData
    {
        public const string MODULE = "Breeds";

        public List<BreedRoleByBreed> breedRoles;

        public List<uint> breedSpellsId;

        public uint creatureBonesId;

        public uint descriptionId;

        public int femaleArtwork;

        public List<uint> femaleColors;

        public string femaleLook;

        public uint gameplayDescriptionId;
        public int id;

        public uint longNameId;

        public int maleArtwork;

        public List<uint> maleColors;

        public string maleLook;

        public uint shortNameId;

        public uint spawnMap;

        public List<List<uint>> statsPointsForAgility;

        public List<List<uint>> statsPointsForChance;

        public List<List<uint>> statsPointsForIntelligence;

        public List<List<uint>> statsPointsForStrength;

        public List<List<uint>> statsPointsForVitality;

        public List<List<uint>> statsPointsForWisdom;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint ShortNameId
        {
            get { return shortNameId; }

            set { shortNameId = value; }
        }

        [D2OIgnore]
        public uint LongNameId
        {
            get { return longNameId; }

            set { longNameId = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public uint GameplayDescriptionId
        {
            get { return gameplayDescriptionId; }

            set { gameplayDescriptionId = value; }
        }

        [D2OIgnore]
        public string MaleLook
        {
            get { return maleLook; }

            set { maleLook = value; }
        }

        [D2OIgnore]
        public string FemaleLook
        {
            get { return femaleLook; }

            set { femaleLook = value; }
        }

        [D2OIgnore]
        public uint CreatureBonesId
        {
            get { return creatureBonesId; }

            set { creatureBonesId = value; }
        }

        [D2OIgnore]
        public int MaleArtwork
        {
            get { return maleArtwork; }

            set { maleArtwork = value; }
        }

        [D2OIgnore]
        public int FemaleArtwork
        {
            get { return femaleArtwork; }

            set { femaleArtwork = value; }
        }

        [D2OIgnore]
        public List<List<uint>> StatsPointsForStrength
        {
            get { return statsPointsForStrength; }

            set { statsPointsForStrength = value; }
        }

        [D2OIgnore]
        public List<List<uint>> StatsPointsForIntelligence
        {
            get { return statsPointsForIntelligence; }

            set { statsPointsForIntelligence = value; }
        }

        [D2OIgnore]
        public List<List<uint>> StatsPointsForChance
        {
            get { return statsPointsForChance; }

            set { statsPointsForChance = value; }
        }

        [D2OIgnore]
        public List<List<uint>> StatsPointsForAgility
        {
            get { return statsPointsForAgility; }

            set { statsPointsForAgility = value; }
        }

        [D2OIgnore]
        public List<List<uint>> StatsPointsForVitality
        {
            get { return statsPointsForVitality; }

            set { statsPointsForVitality = value; }
        }

        [D2OIgnore]
        public List<List<uint>> StatsPointsForWisdom
        {
            get { return statsPointsForWisdom; }

            set { statsPointsForWisdom = value; }
        }

        [D2OIgnore]
        public List<uint> BreedSpellsId
        {
            get { return breedSpellsId; }

            set { breedSpellsId = value; }
        }

        [D2OIgnore]
        public List<BreedRoleByBreed> BreedRoles
        {
            get { return breedRoles; }

            set { breedRoles = value; }
        }

        [D2OIgnore]
        public List<uint> MaleColors
        {
            get { return maleColors; }

            set { maleColors = value; }
        }

        [D2OIgnore]
        public List<uint> FemaleColors
        {
            get { return femaleColors; }

            set { femaleColors = value; }
        }

        [D2OIgnore]
        public uint SpawnMap
        {
            get { return spawnMap; }

            set { spawnMap = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}