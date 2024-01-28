// Generated on 06/05/2015 03:00:15

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Idols", "com.ankamagames.dofus.datacenter.idols", true)]
    public class Idol : IDataObject, IIndexedData
    {
        public const string MODULE = "Idols";

        public int categoryId;

        public string description;

        public int dropBonus;

        public int experienceBonus;

        public bool groupOnly;
        public int id;

        public int itemId;

        public int score;

        public int spellPairId;

        public List<double> synergyIdolsCoeff;

        public List<int> synergyIdolsIds;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string Description
        {
            get { return description; }

            set { description = value; }
        }

        [D2OIgnore]
        public int CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        [D2OIgnore]
        public int ItemId
        {
            get { return itemId; }

            set { itemId = value; }
        }

        [D2OIgnore]
        public bool GroupOnly
        {
            get { return groupOnly; }

            set { groupOnly = value; }
        }

        [D2OIgnore]
        public int SpellPairId
        {
            get { return spellPairId; }

            set { spellPairId = value; }
        }

        [D2OIgnore]
        public int Score
        {
            get { return score; }

            set { score = value; }
        }

        [D2OIgnore]
        public int ExperienceBonus
        {
            get { return experienceBonus; }

            set { experienceBonus = value; }
        }

        [D2OIgnore]
        public int DropBonus
        {
            get { return dropBonus; }

            set { dropBonus = value; }
        }

        [D2OIgnore]
        public List<int> SynergyIdolsIds
        {
            get { return synergyIdolsIds; }

            set { synergyIdolsIds = value; }
        }

        [D2OIgnore]
        public List<double> SynergyIdolsCoeff
        {
            get { return synergyIdolsCoeff; }

            set { synergyIdolsCoeff = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}