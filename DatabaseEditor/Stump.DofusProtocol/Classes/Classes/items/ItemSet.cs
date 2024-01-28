// Generated on 06/05/2015 03:00:15

using System.Collections.Generic;
using Stump.DofusProtocol.D2oClasses;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ItemSets", "com.ankamagames.dofus.datacenter.items", true)]
    public class ItemSet : IDataObject, IIndexedData
    {
        public const string MODULE = "ItemSets";

        public bool bonusIsSecret;

        public List<List<EffectInstance>> effects;
        public int id;

        public List<uint> items;

        public uint nameId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public List<uint> Items
        {
            get { return items; }

            set { items = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public List<List<EffectInstance>> Effects
        {
            get { return effects; }

            set { effects = value; }
        }

        [D2OIgnore]
        public bool BonusIsSecret
        {
            get { return bonusIsSecret; }

            set { bonusIsSecret = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}