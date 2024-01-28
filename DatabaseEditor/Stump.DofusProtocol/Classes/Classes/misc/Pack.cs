// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Pack", "com.ankamagames.dofus.datacenter.misc", true)]
    public class Pack : IDataObject, IIndexedData
    {
        public const string MODULE = "Pack";

        public bool hasSubAreas;
        public int id;

        public string name;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        [D2OIgnore]
        public bool HasSubAreas
        {
            get { return hasSubAreas; }

            set { hasSubAreas = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}