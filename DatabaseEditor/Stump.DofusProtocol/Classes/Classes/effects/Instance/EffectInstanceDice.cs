// Generated on 02/08/2015 21:50:03

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("EffectInstanceDice", "com.ankamagames.dofus.datacenter.effects.instances"), Serializable]
    public class EffectInstanceDice : EffectInstanceInteger
    {
        public uint diceNum;

        public uint diceSide;

        public int Id => (int) EffectId;

        [D2OIgnore]
        public uint DiceNum
        {
            get { return diceNum; }

            set { diceNum = value; }
        }

        [D2OIgnore]
        public uint DiceSide
        {
            get { return diceSide; }

            set { diceSide = value; }
        }
    }
}