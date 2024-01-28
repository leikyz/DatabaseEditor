



















// Generated on 04/20/2016 12:03:09
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
{

public const ushort Id = 5741;
public override ushort MessageId
{
    get { return Id; }
}

public short markId;
        public double triggeringCharacterId;
        public ushort triggeredSpellId;
        

public GameActionFightTriggerGlyphTrapMessage()
{
}

public GameActionFightTriggerGlyphTrapMessage(ushort actionId, double sourceId, short markId, double triggeringCharacterId, ushort triggeredSpellId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.triggeringCharacterId = triggeringCharacterId;
            this.triggeredSpellId = triggeredSpellId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteDouble(triggeringCharacterId);
            writer.WriteVarUhShort(triggeredSpellId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            triggeringCharacterId = reader.ReadDouble();
            if (triggeringCharacterId < -9.007199254740992E15 || triggeringCharacterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on triggeringCharacterId = " + triggeringCharacterId + ", it doesn't respect the following condition : triggeringCharacterId < -9.007199254740992E15 || triggeringCharacterId > 9.007199254740992E15");
            triggeredSpellId = reader.ReadVarUhShort();
            if (triggeredSpellId < 0)
                throw new Exception("Forbidden value on triggeredSpellId = " + triggeredSpellId + ", it doesn't respect the following condition : triggeredSpellId < 0");
            

}


}


}