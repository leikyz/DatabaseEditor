// Generated on 06/05/2015 03:00:14

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ExternalNotifications", "com.ankamagames.dofus.datacenter.externalnotifications", true)]
    public class ExternalNotification : IDataObject, IIndexedData
    {
        public const string MODULE = "ExternalNotifications";

        public int categoryId;

        public int colorId;

        public bool defaultEnable;

        public bool defaultMultiAccount;

        public bool defaultNotify;

        public bool defaultSound;

        public uint descriptionId;

        public int iconId;
        public int id;

        public uint messageId;

        public string name;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public int ColorId
        {
            get { return colorId; }

            set { colorId = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public bool DefaultEnable
        {
            get { return defaultEnable; }

            set { defaultEnable = value; }
        }

        [D2OIgnore]
        public bool DefaultSound
        {
            get { return defaultSound; }

            set { defaultSound = value; }
        }

        [D2OIgnore]
        public bool DefaultNotify
        {
            get { return defaultNotify; }

            set { defaultNotify = value; }
        }

        [D2OIgnore]
        public bool DefaultMultiAccount
        {
            get { return defaultMultiAccount; }

            set { defaultMultiAccount = value; }
        }

        [D2OIgnore]
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        [D2OIgnore]
        public uint MessageId
        {
            get { return messageId; }

            set { messageId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}