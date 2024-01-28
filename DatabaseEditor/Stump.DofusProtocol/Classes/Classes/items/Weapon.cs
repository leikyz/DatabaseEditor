// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.D2oClasses;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Weapon", "com.ankamagames.dofus.datacenter.items", true)]
    public class Weapon : Item
    {
        public int apCost;

        public bool castInDiagonal;

        public bool castInLine;

        public bool castTestLos;

        public int criticalFailureProbability;

        public int criticalHitBonus;

        public int criticalHitProbability;

        public uint maxCastPerTurn;

        public int minRange;

        public int range;

        [D2OIgnore]
        public int ApCost
        {
            get { return apCost; }

            set { apCost = value; }
        }

        [D2OIgnore]
        public int MinRange
        {
            get { return minRange; }

            set { minRange = value; }
        }

        [D2OIgnore]
        public int Range
        {
            get { return range; }

            set { range = value; }
        }

        [D2OIgnore]
        public uint MaxCastPerTurn
        {
            get { return maxCastPerTurn; }

            set { maxCastPerTurn = value; }
        }

        [D2OIgnore]
        public bool CastInLine
        {
            get { return castInLine; }

            set { castInLine = value; }
        }

        [D2OIgnore]
        public bool CastInDiagonal
        {
            get { return castInDiagonal; }

            set { castInDiagonal = value; }
        }

        [D2OIgnore]
        public bool CastTestLos
        {
            get { return castTestLos; }

            set { castTestLos = value; }
        }

        [D2OIgnore]
        public int CriticalHitProbability
        {
            get { return criticalHitProbability; }

            set { criticalHitProbability = value; }
        }

        [D2OIgnore]
        public int CriticalHitBonus
        {
            get { return criticalHitBonus; }

            set { criticalHitBonus = value; }
        }

        [D2OIgnore]
        public int CriticalFailureProbability
        {
            get { return criticalFailureProbability; }

            set { criticalFailureProbability = value; }
        }
    }
}