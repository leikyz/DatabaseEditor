// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CreatureBonesOverrides", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class CreatureBoneOverride : IDataObject, IIndexedData
    {
        public const string MODULE = "CreatureBonesOverrides";
        public int boneId;

        public int creatureBoneId;

        [D2OIgnore]
        public int BoneId
        {
            get { return boneId; }

            set { boneId = value; }
        }

        [D2OIgnore]
        public int CreatureBoneId
        {
            get { return creatureBoneId; }

            set { creatureBoneId = value; }
        }

        int IIndexedData.Id
        {
            get { return boneId; }
        }
    }
}