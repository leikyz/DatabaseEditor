// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Challenge", "com.ankamagames.dofus.datacenter.challenges", true)]
    public class Challenge : IDataObject, IIndexedData
    {
        public const string MODULE = "Challenge";

        public uint descriptionId;
        public int id;

        public uint nameId;

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
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}