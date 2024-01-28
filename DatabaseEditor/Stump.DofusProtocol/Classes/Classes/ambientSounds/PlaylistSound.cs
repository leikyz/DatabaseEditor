// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("PlaylistSounds", "com.ankamagames.dofus.datacenter.ambientSounds", true)]
    public class PlaylistSound : IDataObject
    {
        public const string MODULE = "PlaylistSounds";

        public int channel;
        public string id;

        public int volume;

        [D2OIgnore]
        public string Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int Volume
        {
            get { return volume; }

            set { volume = value; }
        }

        [D2OIgnore]
        public int Channel
        {
            get { return channel; }

            set { channel = value; }
        }
    }
}