// Generated on 06/05/2015 03:00:18

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Jobs", "com.ankamagames.dofus.datacenter.jobs")]
    public class Job : IDataObject, IIndexedData
    {
        private const string MODULE = "Jobs";
        public int id;
        public uint nameId;
        public int iconId;
        int IIndexedData.Id => id;

        [D2OIgnore]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        [D2OIgnore]
        public uint NameId
        {
            get
            {
                return nameId;
            }
            set
            {
                nameId = value;
            }
        }
        [D2OIgnore]
        public int IconId
        {
            get
            {
                return iconId;
            }
            set
            {
                iconId = value;
            }
        }
    }
}