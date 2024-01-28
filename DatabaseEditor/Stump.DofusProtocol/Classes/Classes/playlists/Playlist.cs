// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Playlists", "com.ankamagames.dofus.datacenter.playlists", true)]
    public class Playlist : IDataObject, IIndexedData
    {
        public const int AMBIENT_TYPE_ROLEPLAY = 1;
        public const int AMBIENT_TYPE_AMBIENT = 2;
        public const int AMBIENT_TYPE_FIGHT = 3;
        public const int AMBIENT_TYPE_BOSS = 4;
        public const string MODULE = "Playlists";
        public int id;

        public int iteration;

        public int silenceDuration;

        public List<PlaylistSound> sounds;

        public int type;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public int SilenceDuration
        {
            get { return silenceDuration; }

            set { silenceDuration = value; }
        }

        [D2OIgnore]
        public int Iteration
        {
            get { return iteration; }

            set { iteration = value; }
        }

        [D2OIgnore]
        public int Type
        {
            get { return type; }

            set { type = value; }
        }

        [D2OIgnore]
        public List<PlaylistSound> Sounds
        {
            get { return sounds; }

            set { sounds = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}