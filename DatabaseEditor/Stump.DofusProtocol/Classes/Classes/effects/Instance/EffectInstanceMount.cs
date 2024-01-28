// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceMount", "com.ankamagames.dofus.datacenter.effects.instances", true), Serializable]
    public class EffectInstanceMount : EffectInstance
    {
        public float date;

        public uint modelId;

        public uint mountId;

        public int Id => (int) modelId;

        [D2OIgnore]
        public float Date
        {
            get { return date; }

            set { date = value; }
        }

        [D2OIgnore]
        public uint ModelId
        {
            get { return modelId; }

            set { modelId = value; }
        }

        [D2OIgnore]
        public uint MountId
        {
            get { return mountId; }

            set { mountId = value; }
        }
    }
}