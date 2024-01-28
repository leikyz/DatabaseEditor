// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MonsterMiniBoss", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class MonsterMiniBoss : IDataObject, IIndexedData
    {
        public const string MODULE = "MonsterMiniBoss";
        public int id;

        public int monsterReplacingId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int MonsterReplacingId
        {
            get { return monsterReplacingId; }

            set { monsterReplacingId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}