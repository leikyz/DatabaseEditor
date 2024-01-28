



















// Generated on 04/20/2016 12:03:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
{

public const ushort Id = 6116;
public override ushort MessageId
{
    get { return Id; }
}

public ushort weaponGenericId;
        

public GameActionFightCloseCombatMessage()
{
}

public GameActionFightCloseCombatMessage(ushort actionId, double sourceId, double targetId, short destinationCellId, sbyte critical, bool silentCast, ushort weaponGenericId)
         : base(actionId, sourceId, targetId, destinationCellId, critical, silentCast)
        {
            this.weaponGenericId = weaponGenericId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(weaponGenericId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            weaponGenericId = reader.ReadVarUhShort();
            if (weaponGenericId < 0)
                throw new Exception("Forbidden value on weaponGenericId = " + weaponGenericId + ", it doesn't respect the following condition : weaponGenericId < 0");
            

}


}


}