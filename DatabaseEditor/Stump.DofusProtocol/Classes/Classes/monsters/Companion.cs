// Generated on 06/05/2015 03:00:19

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Companions", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class Companion : IDataObject, IIndexedData
    {
        public const string MODULE = "Companions";

        public uint assetId;

        public List<uint> characteristics;

        public int creatureBoneId;

        public uint descriptionId;
        public int id;

        public string look;

        public uint nameId;

        public List<uint> spells;

        public uint startingSpellLevelId;

        public bool webDisplay;

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
        public string Look
        {
            get { return look; }

            set { look = value; }
        }

        [D2OIgnore]
        public bool WebDisplay
        {
            get { return webDisplay; }

            set { webDisplay = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public uint StartingSpellLevelId
        {
            get { return startingSpellLevelId; }

            set { startingSpellLevelId = value; }
        }

        [D2OIgnore]
        public uint AssetId
        {
            get { return assetId; }

            set { assetId = value; }
        }

        [D2OIgnore]
        public List<uint> Characteristics
        {
            get { return characteristics; }

            set { characteristics = value; }
        }

        [D2OIgnore]
        public List<uint> Spells
        {
            get { return spells; }

            set { spells = value; }
        }

        [D2OIgnore]
        public int CreatureBoneId
        {
            get { return creatureBoneId; }

            set { creatureBoneId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}