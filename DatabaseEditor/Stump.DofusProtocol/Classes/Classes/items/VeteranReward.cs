// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("VeteranRewards", "com.ankamagames.dofus.datacenter.items", true)]
    public class VeteranReward : IDataObject, IIndexedData
    {
        public const string MODULE = "VeteranRewards";
        public int id;

        public uint itemGID;

        public uint itemQuantity;

        public uint requiredSubDays;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint RequiredSubDays
        {
            get { return requiredSubDays; }

            set { requiredSubDays = value; }
        }

        [D2OIgnore]
        public uint ItemGID
        {
            get { return itemGID; }

            set { itemGID = value; }
        }

        [D2OIgnore]
        public uint ItemQuantity
        {
            get { return itemQuantity; }

            set { itemQuantity = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}