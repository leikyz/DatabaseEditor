



















// Generated on 04/20/2016 12:03:51
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SpellItemBoostMessage : Message
{

public const ushort Id = 6011;
public override ushort MessageId
{
    get { return Id; }
}

public uint statId;
        public ushort spellId;
        public short value;
        

public SpellItemBoostMessage()
{
}

public SpellItemBoostMessage(uint statId, ushort spellId, short value)
        {
            this.statId = statId;
            this.spellId = spellId;
            this.value = value;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(statId);
            writer.WriteVarUhShort(spellId);
            writer.WriteVarShort(value);
            

}

public override void Deserialize(ICustomDataInput reader)
{

statId = reader.ReadVarUhInt();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            value = reader.ReadVarShort();
            

}


}


}