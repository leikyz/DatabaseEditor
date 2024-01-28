// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Url", "com.ankamagames.dofus.datacenter.misc", true)]
    public class Url : IDataObject, IIndexedData
    {
        public const string MODULE = "Url";

        public int browserId;
        public int id;

        public string method;

        public string param;

        public string url;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int BrowserId
        {
            get { return browserId; }

            set { browserId = value; }
        }

        [D2OIgnore]
        public string Urls
        {
            get { return url; }

            set { url = value; }
        }

        [D2OIgnore]
        public string Param
        {
            get { return param; }

            set { param = value; }
        }

        [D2OIgnore]
        public string Method
        {
            get { return method; }

            set { method = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}