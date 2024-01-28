// Generated on 06/05/2015 03:00:23

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SpellStates", "com.ankamagames.dofus.datacenter.spells", true)]
    public class SpellState : IDataObject, IIndexedData
    {
        public const string MODULE = "SpellStates";

        public List<int> effectsIds;
        public int id;

        public bool isSilent;

        public uint nameId;

        public bool preventsFight;

        public bool preventsSpellCast;

        public bool cantBeMoved;

        public bool cantBePushed;

        public bool cantDealDamage;

        public bool invulnerable;

        public bool cantSwitchPosition;

        public bool incurable;

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
        public bool PreventsSpellCast
        {
            get { return preventsSpellCast; }

            set { preventsSpellCast = value; }
        }

        [D2OIgnore]
        public bool PreventsFight
        {
            get { return preventsFight; }

            set { preventsFight = value; }
        }

        [D2OIgnore]
        public bool IsSilent
        {
            get { return isSilent; }

            set { isSilent = value; }
        }

        [D2OIgnore]
        public List<int> EffectsIds
        {
            get { return effectsIds; }

            set { effectsIds = value; }
        }

        int IIndexedData.Id => id;

        public bool CantBeMoved
        {
            get { return cantBeMoved; }

            set { cantBeMoved = value; }
        }

        public bool CantBePushed
        {
            get { return cantBePushed; }

            set { cantBePushed = value; }
        }

        public bool CantDealDamage
        {
            get { return cantDealDamage; }

            set { cantDealDamage = value; }
        }

        public bool Invulnerable
        {
            get
            {
                return invulnerable;
            }

            set
            {
                invulnerable = value;
            }
        }

        public bool CantSwitchPosition
        {
            get
            {
                return cantSwitchPosition;
            }

            set
            {
                cantSwitchPosition = value;
            }
        }

        public bool Incurable
        {
            get
            {
                return incurable;
            }

            set
            {
                incurable = value;
            }
        }
    }
}