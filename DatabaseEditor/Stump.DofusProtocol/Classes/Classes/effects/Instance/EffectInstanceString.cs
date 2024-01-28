// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceString", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceString : EffectInstance
    {
        public string text;

        [D2OIgnore]
        public string Text
        {
            get { return text; }

            set { text = value; }
        }
    }
}