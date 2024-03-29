



















// Generated on 04/20/2016 12:44:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 193;
public override short TypeId
{
    get { return Id; }
}

public uint grade;
        

public CharacterMinimalPlusLookAndGradeInformations()
{
}

public CharacterMinimalPlusLookAndGradeInformations(ulong id, string name, byte level, Types.EntityLook entityLook, uint grade)
         : base(id, name, level, entityLook)
        {
            this.grade = grade;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhInt(grade);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            grade = reader.ReadVarUhInt();
            if (grade < 0)
                throw new Exception("Forbidden value on grade = " + grade + ", it doesn't respect the following condition : grade < 0");
            

}


}


}