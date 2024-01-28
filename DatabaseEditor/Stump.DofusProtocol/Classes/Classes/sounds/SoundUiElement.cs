// Generated on 06/05/2015 03:00:22

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SoundUiElement", "com.ankamagames.dofus.datacenter.sounds", true)]
    public class SoundUiElement : IDataObject, IIndexedData
    {
        public string file;

        public uint hookId;
        public int id;
        public string MODULE = "SoundUiElement";

        public string name;

        public uint volume;

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
        public uint HookId
        {
            get { return hookId; }

            set { hookId = value; }
        }

        [D2OIgnore]
        public string File
        {
            get { return file; }

            set { file = value; }
        }

        [D2OIgnore]
        public uint Volume
        {
            get { return volume; }

            set { volume = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}