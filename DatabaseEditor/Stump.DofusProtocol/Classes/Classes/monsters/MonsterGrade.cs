// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MonsterGrade", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class MonsterGrade : IDataObject, IIndexedData
    {
        public int actionPoints;

        public int airResistance;

        public int damageReflect;

        public int earthResistance;

        public int fireResistance;
        public uint grade;

        public int gradeXp;

        public uint level;

        public int lifePoints;

        public int monsterId;

        public int movementPoints;

        public int neutralResistance;

        public int paDodge;

        public int pmDodge;

        public int waterResistance;

        public int wisdom;

        public uint hiddenLevel;

        [D2OIgnore]
        public uint Grade
        {
            get { return grade; }

            set { grade = value; }
        }

        [D2OIgnore]
        public int MonsterId
        {
            get { return monsterId; }

            set { monsterId = value; }
        }

        [D2OIgnore]
        public uint Level
        {
            get { return level; }

            set { level = value; }
        }

        [D2OIgnore]
        public int PaDodge
        {
            get { return paDodge; }

            set { paDodge = value; }
        }

        [D2OIgnore]
        public int PmDodge
        {
            get { return pmDodge; }

            set { pmDodge = value; }
        }

        [D2OIgnore]
        public int Wisdom
        {
            get { return wisdom; }

            set { wisdom = value; }
        }

        [D2OIgnore]
        public int EarthResistance
        {
            get { return earthResistance; }

            set { earthResistance = value; }
        }

        [D2OIgnore]
        public int AirResistance
        {
            get { return airResistance; }

            set { airResistance = value; }
        }

        [D2OIgnore]
        public int FireResistance
        {
            get { return fireResistance; }

            set { fireResistance = value; }
        }

        [D2OIgnore]
        public int WaterResistance
        {
            get { return waterResistance; }

            set { waterResistance = value; }
        }

        [D2OIgnore]
        public int NeutralResistance
        {
            get { return neutralResistance; }

            set { neutralResistance = value; }
        }

        [D2OIgnore]
        public int GradeXp
        {
            get { return gradeXp; }

            set { gradeXp = value; }
        }

        [D2OIgnore]
        public int LifePoints
        {
            get { return lifePoints; }

            set { lifePoints = value; }
        }

        [D2OIgnore]
        public int ActionPoints
        {
            get { return actionPoints; }

            set { actionPoints = value; }
        }

        [D2OIgnore]
        public int MovementPoints
        {
            get { return movementPoints; }

            set { movementPoints = value; }
        }

        [D2OIgnore]
        public int DamageReflect
        {
            get { return damageReflect; }

            set { damageReflect = value; }
        }

        int IIndexedData.Id
        {
            get { return monsterId; }
        }

        public uint HiddenLevel
        {
            get
            {
                return hiddenLevel;
            }

            set
            {
                hiddenLevel = value;
            }
        }
    }
}