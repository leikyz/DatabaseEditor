// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("InfoMessages", "com.ankamagames.dofus.datacenter.communication", true)]
    public class InfoMessage : IDataObject, IIndexedData
    {
        public const string MODULE = "InfoMessages";

        public uint messageId;

        public uint textId;
        public uint typeId;

        [D2OIgnore]
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public uint MessageId
        {
            get { return messageId; }

            set { messageId = value; }
        }

        [D2OIgnore]
        public uint TextId
        {
            get { return textId; }

            set { textId = value; }
        }

        int IIndexedData.Id
        {
            get { return (int) typeId; }
        }
    }
}