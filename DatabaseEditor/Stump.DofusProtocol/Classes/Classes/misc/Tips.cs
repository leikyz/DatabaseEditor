// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Tips", "com.ankamagames.dofus.datacenter.misc", true)]
    public class Tips : IDataObject, IIndexedData
    {
        public const string MODULE = "Tips";

        public uint descId;
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint DescId
        {
            get { return descId; }

            set { descId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}