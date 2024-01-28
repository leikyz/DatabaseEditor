// Generated on 06/05/2015 03:00:11

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentGift", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentGift : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentGift";

        public int effectId;

        public uint gfxId;
        public int id;

        public uint nameId;

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
        public int EffectId
        {
            get { return effectId; }

            set { effectId = value; }
        }

        [D2OIgnore]
        public uint GfxId
        {
            get { return gfxId; }

            set { gfxId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}