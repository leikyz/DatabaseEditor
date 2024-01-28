// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AchievementObjectives", "com.ankamagames.dofus.datacenter.quest", true)]
    public class AchievementObjective : IDataObject, IIndexedData
    {
        public const string MODULE = "AchievementObjectives";

        public uint achievementId;

        public string criterion;
        public uint id;

        public uint nameId;

        public uint order;

        [D2OIgnore]
        public uint Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint AchievementId
        {
            get { return achievementId; }

            set { achievementId = value; }
        }

        [D2OIgnore]
        public uint Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public string Criterion
        {
            get { return criterion; }

            set { criterion = value; }
        }

        int IIndexedData.Id
        {
            get { return (int)id; }
        }
    }
}