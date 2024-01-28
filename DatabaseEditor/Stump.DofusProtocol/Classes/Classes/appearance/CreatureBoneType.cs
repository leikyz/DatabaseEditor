// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CreatureBonesTypes", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class CreatureBoneType : IDataObject, IIndexedData
    {
        public const string MODULE = "CreatureBonesTypes";

        public int creatureBoneId;
        public int id;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int CreatureBoneId
        {
            get { return creatureBoneId; }

            set { creatureBoneId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}