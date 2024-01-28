// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MonsterDrop", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class MonsterDrop : IDataObject, IIndexedData
    {
        public int count;
        public uint dropId;

        public bool hasCriteria;

        public int monsterId;

        public int objectId;

        public float percentDropForGrade1;

        public float percentDropForGrade2;

        public float percentDropForGrade3;

        public float percentDropForGrade4;

        public float percentDropForGrade5;

        [D2OIgnore]
        public uint DropId
        {
            get { return dropId; }

            set { dropId = value; }
        }

        [D2OIgnore]
        public int MonsterId
        {
            get { return monsterId; }

            set { monsterId = value; }
        }

        [D2OIgnore]
        public int ObjectId
        {
            get { return objectId; }

            set { objectId = value; }
        }

        [D2OIgnore]
        public float PercentDropForGrade1
        {
            get { return percentDropForGrade1; }

            set { percentDropForGrade1 = value; }
        }

        [D2OIgnore]
        public float PercentDropForGrade2
        {
            get { return percentDropForGrade2; }

            set { percentDropForGrade2 = value; }
        }

        [D2OIgnore]
        public float PercentDropForGrade3
        {
            get { return percentDropForGrade3; }

            set { percentDropForGrade3 = value; }
        }

        [D2OIgnore]
        public float PercentDropForGrade4
        {
            get { return percentDropForGrade4; }

            set { percentDropForGrade4 = value; }
        }

        [D2OIgnore]
        public float PercentDropForGrade5
        {
            get { return percentDropForGrade5; }

            set { percentDropForGrade5 = value; }
        }

        [D2OIgnore]
        public int Count
        {
            get { return count; }

            set { count = value; }
        }

        [D2OIgnore]
        public bool HasCriteria
        {
            get { return hasCriteria; }

            set { hasCriteria = value; }
        }

        int IIndexedData.Id
        {
            get { return (int) dropId; }
        }
    }
}