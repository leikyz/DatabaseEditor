// Generated on 06/05/2015 03:00:19

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MonsterRaces", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class MonsterRace : IDataObject, IIndexedData
    {
        public const string MODULE = "MonsterRaces";
        public int id;

        public List<uint> monsters;

        public uint nameId;

        public int superRaceId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int SuperRaceId
        {
            get { return superRaceId; }

            set { superRaceId = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public List<uint> Monsters
        {
            get { return monsters; }

            set { monsters = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}