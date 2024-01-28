// Generated on 06/05/2015 03:00:22

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ServerCommunities", "com.ankamagames.dofus.datacenter.servers", true)]
    public class ServerCommunity : IDataObject, IIndexedData
    {
        public const string MODULE = "ServerCommunities";

        public List<string> defaultCountries;
        public int id;

        public uint nameId;

        public string shortId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public string ShortId
        {
            get { return shortId; }

            set { shortId = value; }
        }

        [D2OIgnore]
        public List<string> DefaultCountries
        {
            get { return defaultCountries; }

            set { defaultCountries = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}