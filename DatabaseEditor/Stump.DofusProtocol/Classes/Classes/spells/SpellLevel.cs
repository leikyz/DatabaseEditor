// Generated on 06/05/2015 03:00:22

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SpellLevels", "com.ankamagames.dofus.datacenter.spells", true)]
    public class SpellLevel : IDataObject, IIndexedData
    {
        public const string MODULE = "SpellLevels";

        public uint apCost;

        public bool castInDiagonal;

        public bool castInLine;

        public bool castTestLos;

        public List<EffectInstanceDice> criticalEffect;

        public bool criticalFailureEndsTurn;

        public uint criticalFailureProbability;

        public uint criticalHitProbability;

        public List<EffectInstanceDice> effects;

        public int globalCooldown;

        public uint grade;

        public bool hidden;

        public bool hideEffects;
        public int id;

        public uint initialCooldown;

        public uint maxCastPerTarget;

        public uint maxCastPerTurn;

        public int maxStack;

        public uint minCastInterval;

        public uint minPlayerLevel;

        public uint minRange;

        public bool needFreeCell;

        public bool needFreeTrapCell;

        public bool needTakenCell;

        public uint range;

        public bool rangeCanBeBoosted;

        public uint spellBreed;

        public uint spellId;

        public List<int> statesForbidden;

        public List<int> statesRequired;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint SpellId
        {
            get { return spellId; }

            set { spellId = value; }
        }

        [D2OIgnore]
        public uint Grade
        {
            get { return grade; }

            set { grade = value; }
        }

        [D2OIgnore]
        public uint SpellBreed
        {
            get { return spellBreed; }

            set { spellBreed = value; }
        }

        [D2OIgnore]
        public uint ApCost
        {
            get { return apCost; }

            set { apCost = value; }
        }

        [D2OIgnore]
        public uint MinRange
        {
            get { return minRange; }

            set { minRange = value; }
        }

        [D2OIgnore]
        public uint Range
        {
            get { return range; }

            set { range = value; }
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
        public uint CriticalHitProbability
        {
            get { return criticalHitProbability; }

            set { criticalHitProbability = value; }
        }

        [D2OIgnore]
        public uint CriticalFailureProbability
        {
            get { return criticalFailureProbability; }

            set { criticalFailureProbability = value; }
        }

        [D2OIgnore]
        public bool NeedFreeCell
        {
            get { return needFreeCell; }

            set { needFreeCell = value; }
        }

        [D2OIgnore]
        public bool NeedTakenCell
        {
            get { return needTakenCell; }

            set { needTakenCell = value; }
        }

        [D2OIgnore]
        public bool NeedFreeTrapCell
        {
            get { return needFreeTrapCell; }

            set { needFreeTrapCell = value; }
        }

        [D2OIgnore]
        public bool RangeCanBeBoosted
        {
            get { return rangeCanBeBoosted; }

            set { rangeCanBeBoosted = value; }
        }

        [D2OIgnore]
        public int MaxStack
        {
            get { return maxStack; }

            set { maxStack = value; }
        }

        [D2OIgnore]
        public uint MaxCastPerTurn
        {
            get { return maxCastPerTurn; }

            set { maxCastPerTurn = value; }
        }

        [D2OIgnore]
        public uint MaxCastPerTarget
        {
            get { return maxCastPerTarget; }

            set { maxCastPerTarget = value; }
        }

        [D2OIgnore]
        public uint MinCastInterval
        {
            get { return minCastInterval; }

            set { minCastInterval = value; }
        }

        [D2OIgnore]
        public uint InitialCooldown
        {
            get { return initialCooldown; }

            set { initialCooldown = value; }
        }

        [D2OIgnore]
        public int GlobalCooldown
        {
            get { return globalCooldown; }

            set { globalCooldown = value; }
        }

        [D2OIgnore]
        public uint MinPlayerLevel
        {
            get { return minPlayerLevel; }

            set { minPlayerLevel = value; }
        }

        [D2OIgnore]
        public bool CriticalFailureEndsTurn
        {
            get { return criticalFailureEndsTurn; }

            set { criticalFailureEndsTurn = value; }
        }

        [D2OIgnore]
        public bool HideEffects
        {
            get { return hideEffects; }

            set { hideEffects = value; }
        }

        [D2OIgnore]
        public bool Hidden
        {
            get { return hidden; }

            set { hidden = value; }
        }

        [D2OIgnore]
        public List<int> StatesRequired
        {
            get { return statesRequired; }

            set { statesRequired = value; }
        }

        [D2OIgnore]
        public List<int> StatesForbidden
        {
            get { return statesForbidden; }

            set { statesForbidden = value; }
        }

        [D2OIgnore]
        public List<EffectInstanceDice> Effects
        {
            get { return effects; }

            set { effects = value; }
        }

        [D2OIgnore]
        public List<EffectInstanceDice> CriticalEffect
        {
            get { return criticalEffect; }

            set { criticalEffect = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}