// Generated on 06/05/2015 03:00:22

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SoundUiHook", "com.ankamagames.dofus.datacenter.sounds", true)]
    public class SoundUiHook : IDataObject, IIndexedData
    {
        public int id;
        public string MODULE = "SoundUiHook";

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

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}