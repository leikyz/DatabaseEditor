// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("OptionalFeatures", "com.ankamagames.dofus.datacenter.misc", true)]
    public class OptionalFeature : IDataObject, IIndexedData
    {
        public const string MODULE = "OptionalFeatures";
        public int id;

        public string keyword;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string Keyword
        {
            get { return keyword; }

            set { keyword = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}