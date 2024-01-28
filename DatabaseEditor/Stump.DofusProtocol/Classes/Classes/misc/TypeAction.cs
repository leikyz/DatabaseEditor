// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("TypeActions", "com.ankamagames.dofus.datacenter.misc", true)]
    public class TypeAction : IDataObject, IIndexedData
    {
        public const string MODULE = "TypeActions";

        public int elementId;

        public string elementName;
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string ElementName
        {
            get { return elementName; }

            set { elementName = value; }
        }

        [D2OIgnore]
        public int ElementId
        {
            get { return elementId; }

            set { elementId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}