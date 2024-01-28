// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("NpcMessages", "com.ankamagames.dofus.datacenter.npcs", true)]
    public class NpcMessage : IDataObject, IIndexedData
    {
        public const string MODULE = "NpcMessages";
        public int id;

        public uint messageId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
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