// Generated on 06/05/2015 03:00:22

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SpellBombs", "com.ankamagames.dofus.datacenter.spells", true)]
    public class SpellBomb : IDataObject, IIndexedData
    {
        public const string MODULE = "SpellBombs";

        public int chainReactionSpellId;

        public int comboCoeff;

        public int explodSpellId;
        public int id;

        public int instantSpellId;

        public int wallId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int ChainReactionSpellId
        {
            get { return chainReactionSpellId; }

            set { chainReactionSpellId = value; }
        }

        [D2OIgnore]
        public int ExplodSpellId
        {
            get { return explodSpellId; }

            set { explodSpellId = value; }
        }

        [D2OIgnore]
        public int WallId
        {
            get { return wallId; }

            set { wallId = value; }
        }

        [D2OIgnore]
        public int InstantSpellId
        {
            get { return instantSpellId; }

            set { instantSpellId = value; }
        }

        [D2OIgnore]
        public int ComboCoeff
        {
            get { return comboCoeff; }

            set { comboCoeff = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}