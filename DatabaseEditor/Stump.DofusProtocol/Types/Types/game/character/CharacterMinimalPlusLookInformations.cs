



















// Generated on 04/20/2016 12:44:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
{

public const short Id = 163;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook entityLook;
        

public CharacterMinimalPlusLookInformations()
{
}

public CharacterMinimalPlusLookInformations(ulong id, string name, byte level, Types.EntityLook entityLook)
         : base(id, name, level)
        {
            this.entityLook = entityLook;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            entityLook.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}