



















// Generated on 04/20/2016 12:44:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class FightResultListEntry
{

public const short Id = 16;
public virtual short TypeId
{
    get { return Id; }
}

public ushort outcome;
        public sbyte wave;
        public Types.FightLoot rewards;
        

public FightResultListEntry()
{
}

public FightResultListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.wave = wave;
            this.rewards = rewards;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(outcome);
            writer.WriteSByte(wave);
            rewards.Serialize(writer);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

outcome = reader.ReadVarUhShort();
            if (outcome < 0)
                throw new Exception("Forbidden value on outcome = " + outcome + ", it doesn't respect the following condition : outcome < 0");
            wave = reader.ReadSByte();
            if (wave < 0)
                throw new Exception("Forbidden value on wave = " + wave + ", it doesn't respect the following condition : wave < 0");
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
            

}


}


}