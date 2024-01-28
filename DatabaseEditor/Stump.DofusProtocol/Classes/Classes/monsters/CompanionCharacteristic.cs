// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CompanionCharacteristics", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class CompanionCharacteristic : IDataObject, IIndexedData
    {
        public const string MODULE = "CompanionCharacteristics";

        public int caracId;

        public int companionId;
        public int id;

        public int initialValue;

        public int levelPerValue;

        public int order;

        public int valuePerLevel;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int CaracId
        {
            get { return caracId; }

            set { caracId = value; }
        }

        [D2OIgnore]
        public int CompanionId
        {
            get { return companionId; }

            set { companionId = value; }
        }

        [D2OIgnore]
        public int Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public int InitialValue
        {
            get { return initialValue; }

            set { initialValue = value; }
        }

        [D2OIgnore]
        public int LevelPerValue
        {
            get { return levelPerValue; }

            set { levelPerValue = value; }
        }

        [D2OIgnore]
        public int ValuePerLevel
        {
            get { return valuePerLevel; }

            set { valuePerLevel = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}