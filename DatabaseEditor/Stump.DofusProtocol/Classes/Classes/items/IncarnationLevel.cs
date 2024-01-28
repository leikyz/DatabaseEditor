// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("IncarnationLevels", "com.ankamagames.dofus.datacenter.items", true)]
    public class IncarnationLevel : IDataObject, IIndexedData
    {
        public const string MODULE = "IncarnationLevels";
        public int id;

        public int incarnationId;

        public int level;

        public uint requiredXp;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int IncarnationId
        {
            get { return incarnationId; }

            set { incarnationId = value; }
        }

        [D2OIgnore]
        public int Level
        {
            get { return level; }

            set { level = value; }
        }

        [D2OIgnore]
        public uint RequiredXp
        {
            get { return requiredXp; }

            set { requiredXp = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}