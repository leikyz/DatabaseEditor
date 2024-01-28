



















// Generated on 04/20/2016 12:44:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterMinimalAllianceInformations : CharacterMinimalGuildInformations
{

public const short Id = 444;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicAllianceInformations alliance;
        

public CharacterMinimalAllianceInformations()
{
}

public CharacterMinimalAllianceInformations(ulong id, string name, byte level, Types.EntityLook entityLook, Types.BasicGuildInformations guild, Types.BasicAllianceInformations alliance)
         : base(id, name, level, entityLook, guild)
        {
            this.alliance = alliance;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            alliance.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            alliance = new Types.BasicAllianceInformations();
            alliance.Deserialize(reader);
            

}


}


}