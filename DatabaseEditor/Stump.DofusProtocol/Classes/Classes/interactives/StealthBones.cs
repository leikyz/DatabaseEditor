// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("StealthBones", "com.ankamagames.dofus.datacenter.interactives", true)]
    public class StealthBones : IDataObject, IIndexedData
    {
        public const string MODULE = "StealthBones";
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}