// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AmbientSounds", "com.ankamagames.dofus.datacenter.ambientSounds", true)]
    public class AmbientSound : PlaylistSound
    {
        public const int AMBIENT_TYPE_ROLEPLAY = 1;
        public const int AMBIENT_TYPE_AMBIENT = 2;
        public const int AMBIENT_TYPE_FIGHT = 3;
        public const int AMBIENT_TYPE_BOSS = 4;
        public const string MODULE = "AmbientSounds";
        public int criterionId;

        public uint silenceMax;

        public uint silenceMin;

        public int type_id;

        [D2OIgnore]
        public int CriterionId
        {
            get { return criterionId; }

            set { criterionId = value; }
        }

        [D2OIgnore]
        public uint SilenceMin
        {
            get { return silenceMin; }

            set { silenceMin = value; }
        }

        [D2OIgnore]
        public uint SilenceMax
        {
            get { return silenceMax; }

            set { silenceMax = value; }
        }

        [D2OIgnore]
        public int Type_id
        {
            get { return type_id; }

            set { type_id = value; }
        }
    }
}