



















// Generated on 04/20/2016 12:44:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterBasicMinimalInformations : AbstractCharacterInformation
{

public const short Id = 503;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public CharacterBasicMinimalInformations()
{
}

public CharacterBasicMinimalInformations(ulong id, string name)
         : base(id)
        {
            this.name = name;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}