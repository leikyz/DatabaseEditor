



















// Generated on 04/20/2016 12:44:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
{

public const short Id = 211;
public override short TypeId
{
    get { return Id; }
}

public short weaponTypeId;
        

public FightTemporaryBoostWeaponDamagesEffect()
{
}

public FightTemporaryBoostWeaponDamagesEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta, short weaponTypeId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
        {
            this.weaponTypeId = weaponTypeId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteShort(weaponTypeId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            weaponTypeId = reader.ReadShort();
            

}


}


}