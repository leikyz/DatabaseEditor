



















// Generated on 04/20/2016 12:44:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterMinimalInformations : CharacterBasicMinimalInformations
{

public const short Id = 110;
public override short TypeId
{
    get { return Id; }
}

public byte level;
        

public CharacterMinimalInformations()
{
}

public CharacterMinimalInformations(ulong id, string name, byte level)
         : base(id, name)
        {
            this.level = level;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteByte(level);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            level = reader.ReadByte();
            if (level < 1 || level > 200)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 1 || level > 200");
            

}


}


}