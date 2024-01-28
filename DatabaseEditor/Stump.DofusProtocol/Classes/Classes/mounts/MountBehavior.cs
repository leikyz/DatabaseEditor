// Generated on 06/05/2015 03:00:20

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MountBehaviors", "com.ankamagames.dofus.datacenter.mounts", true)]
    public class MountBehavior : IDataObject, IIndexedData
    {
        public const string MODULE = "MountBehaviors";

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