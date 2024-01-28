// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Incarnation", "com.ankamagames.dofus.datacenter.items", true)]
    public class Incarnation : IDataObject, IIndexedData
    {
        public const string MODULE = "Incarnation";
        public int id;

        public string lookFemale;

        public string lookMale;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string LookMale
        {
            get { return lookMale; }

            set { lookMale = value; }
        }

        [D2OIgnore]
        public string LookFemale
        {
            get { return lookFemale; }

            set { lookFemale = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}