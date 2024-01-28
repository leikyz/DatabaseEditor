// Generated on 06/05/2015 03:00:11

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AbuseReasons", "com.ankamagames.dofus.datacenter.abuse", true)]
    public class AbuseReasons : IDataObject, IIndexedData
    {
        public const string MODULE = "AbuseReasons";
        public uint _abuseReasonId;

        public uint _mask;

        public int _reasonTextId;

        [D2OIgnore]
        public uint AbuseReasonId
        {
            get { return _abuseReasonId; }

            set { _abuseReasonId = value; }
        }

        [D2OIgnore]
        public uint Mask
        {
            get { return _mask; }

            set { _mask = value; }
        }

        [D2OIgnore]
        public int ReasonTextId
        {
            get { return _reasonTextId; }

            set { _reasonTextId = value; }
        }

        int IIndexedData.Id
        {
            get { return (int) _abuseReasonId; }
        }
    }
}