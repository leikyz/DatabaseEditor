// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CompanionSpells", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class CompanionSpell : IDataObject, IIndexedData
    {
        public const string MODULE = "CompanionSpells";

        public int companionId;

        public string gradeByLevel;
        public int id;

        public int spellId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int SpellId
        {
            get { return spellId; }

            set { spellId = value; }
        }

        [D2OIgnore]
        public int CompanionId
        {
            get { return companionId; }

            set { companionId = value; }
        }

        [D2OIgnore]
        public string GradeByLevel
        {
            get { return gradeByLevel; }

            set { gradeByLevel = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}