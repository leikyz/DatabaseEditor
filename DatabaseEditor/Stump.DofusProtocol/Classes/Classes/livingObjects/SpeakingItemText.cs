// Generated on 06/05/2015 03:00:18

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SpeakingItemsText", "com.ankamagames.dofus.datacenter.livingObjects", true)]
    public class SpeakingItemText : IDataObject, IIndexedData
    {
        public const string MODULE = "SpeakingItemsText";
        public int textId;

        public int textLevel;

        public float textProba;

        public string textRestriction;

        public int textSound;

        public uint textStringId;

        [D2OIgnore]
        public int TextId
        {
            get { return textId; }

            set { textId = value; }
        }

        [D2OIgnore]
        public float TextProba
        {
            get { return textProba; }

            set { textProba = value; }
        }

        [D2OIgnore]
        public uint TextStringId
        {
            get { return textStringId; }

            set { textStringId = value; }
        }

        [D2OIgnore]
        public int TextLevel
        {
            get { return textLevel; }

            set { textLevel = value; }
        }

        [D2OIgnore]
        public int TextSound
        {
            get { return textSound; }

            set { textSound = value; }
        }

        [D2OIgnore]
        public string TextRestriction
        {
            get { return textRestriction; }

            set { textRestriction = value; }
        }

        int IIndexedData.Id
        {
            get { return textId; }
        }
    }
}