// Generated on 06/05/2015 03:00:18

using System.Collections.Generic;
using Stump.DofusProtocol.D2oClasses;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Pets", "com.ankamagames.dofus.datacenter.livingObjects", true)]
    public class Pet : IDataObject, IIndexedData
    {
        public const string MODULE = "Pets";

        public List<int> foodItems;

        public List<int> foodTypes;
        public int id;

        public int maxDurationBeforeMeal;

        public int minDurationBeforeMeal;

        public List<EffectInstance> possibleEffects;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public List<int> FoodItems
        {
            get { return foodItems; }

            set { foodItems = value; }
        }

        [D2OIgnore]
        public List<int> FoodTypes
        {
            get { return foodTypes; }

            set { foodTypes = value; }
        }

        [D2OIgnore]
        public int MinDurationBeforeMeal
        {
            get { return minDurationBeforeMeal; }

            set { minDurationBeforeMeal = value; }
        }

        [D2OIgnore]
        public int MaxDurationBeforeMeal
        {
            get { return maxDurationBeforeMeal; }

            set { maxDurationBeforeMeal = value; }
        }

        [D2OIgnore]
        public List<EffectInstance> PossibleEffects
        {
            get { return possibleEffects; }

            set { possibleEffects = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}