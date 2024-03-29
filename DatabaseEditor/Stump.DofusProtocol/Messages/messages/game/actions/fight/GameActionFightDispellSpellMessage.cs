



















// Generated on 04/20/2016 12:03:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
{

public const ushort Id = 6176;
public override ushort MessageId
{
    get { return Id; }
}

public ushort spellId;
        

public GameActionFightDispellSpellMessage()
{
}

public GameActionFightDispellSpellMessage(ushort actionId, double sourceId, double targetId, ushort spellId)
         : base(actionId, sourceId, targetId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(spellId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}