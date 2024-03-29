



















// Generated on 04/20/2016 12:44:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class MonsterInGroupLightInformations
{

public const short Id = 395;
public virtual short TypeId
{
    get { return Id; }
}

public int creatureGenericId;
        public sbyte grade;
        

public MonsterInGroupLightInformations()
{
}

public MonsterInGroupLightInformations(int creatureGenericId, sbyte grade)
        {
            this.creatureGenericId = creatureGenericId;
            this.grade = grade;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(creatureGenericId);
            writer.WriteSByte(grade);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

creatureGenericId = reader.ReadInt();
            grade = reader.ReadSByte();
            if (grade < 0)
                throw new Exception("Forbidden value on grade = " + grade + ", it doesn't respect the following condition : grade < 0");
            

}


}


}