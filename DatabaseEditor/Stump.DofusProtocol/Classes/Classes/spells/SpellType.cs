// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SpellTypes", "com.ankamagames.dofus.datacenter.spells", true)]
    public class SpellType : IDataObject, IIndexedData
    {
        public const string MODULE = "SpellTypes";
        public int id;

        public uint longNameId;

        public uint shortNameId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint LongNameId
        {
            get { return longNameId; }

            set { longNameId = value; }
        }

        [D2OIgnore]
        public uint ShortNameId
        {
            get { return shortNameId; }

            set { shortNameId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}