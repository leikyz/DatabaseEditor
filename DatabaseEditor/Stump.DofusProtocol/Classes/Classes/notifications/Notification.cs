// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Notifications", "com.ankamagames.dofus.datacenter.notifications", true)]
    public class Notification : IDataObject, IIndexedData
    {
        public const string MODULE = "Notifications";

        public int iconId;
        public int id;

        public uint messageId;

        public uint titleId;

        public string trigger;

        public int typeId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint TitleId
        {
            get { return titleId; }

            set { titleId = value; }
        }

        [D2OIgnore]
        public uint MessageId
        {
            get { return messageId; }

            set { messageId = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public int TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public string Trigger
        {
            get { return trigger; }

            set { trigger = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}