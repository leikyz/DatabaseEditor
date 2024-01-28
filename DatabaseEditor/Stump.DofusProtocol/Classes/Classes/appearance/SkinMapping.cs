// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SkinMappings", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class SkinMapping : IDataObject, IIndexedData
    {
        public const string MODULE = "SkinMappings";
        public int id;

        public int lowDefId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int LowDefId
        {
            get { return lowDefId; }

            set { lowDefId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}