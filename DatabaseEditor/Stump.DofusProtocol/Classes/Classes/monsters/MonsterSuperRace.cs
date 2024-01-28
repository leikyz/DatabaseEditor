// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MonsterSuperRaces", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class MonsterSuperRace : IDataObject, IIndexedData
    {
        public const string MODULE = "MonsterSuperRaces";
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

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}