// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ChatChannels", "com.ankamagames.dofus.datacenter.communication", true)]
    public class ChatChannel : IDataObject, IIndexedData
    {
        public const string MODULE = "ChatChannels";

        public bool allowObjects;

        public uint descriptionId;
        public int id;

        public bool isPrivate;

        public uint nameId;

        public string shortcut;

        public string shortcutKey;

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
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public string Shortcut
        {
            get { return shortcut; }

            set { shortcut = value; }
        }

        [D2OIgnore]
        public string ShortcutKey
        {
            get { return shortcutKey; }

            set { shortcutKey = value; }
        }

        [D2OIgnore]
        public bool IsPrivate
        {
            get { return isPrivate; }

            set { isPrivate = value; }
        }

        [D2OIgnore]
        public bool AllowObjects
        {
            get { return allowObjects; }

            set { allowObjects = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}