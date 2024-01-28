



















// Generated on 04/20/2016 12:44:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 445;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicGuildInformations guild;
        

public CharacterMinimalGuildInformations()
{
}

public CharacterMinimalGuildInformations(ulong id, string name, byte level, Types.EntityLook entityLook, Types.BasicGuildInformations guild)
         : base(id, name, level, entityLook)
        {
            this.guild = guild;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}