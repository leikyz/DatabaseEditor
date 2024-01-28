



















// Generated on 04/20/2016 12:44:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class HumanOptionSkillUse : HumanOption
{

public const short Id = 495;
public override short TypeId
{
    get { return Id; }
}

public uint elementId;
        public ushort skillId;
        public double skillEndTime;
        

public HumanOptionSkillUse()
{
}

public HumanOptionSkillUse(uint elementId, ushort skillId, double skillEndTime)
        {
            this.elementId = elementId;
            this.skillId = skillId;
            this.skillEndTime = skillEndTime;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhInt(elementId);
            writer.WriteVarUhShort(skillId);
            writer.WriteDouble(skillEndTime);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            elementId = reader.ReadVarUhInt();
            if (elementId < 0)
                throw new Exception("Forbidden value on elementId = " + elementId + ", it doesn't respect the following condition : elementId < 0");
            skillId = reader.ReadVarUhShort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            skillEndTime = reader.ReadDouble();
            if (skillEndTime < -9.007199254740992E15 || skillEndTime > 9.007199254740992E15)
                throw new Exception("Forbidden value on skillEndTime = " + skillEndTime + ", it doesn't respect the following condition : skillEndTime < -9.007199254740992E15 || skillEndTime > 9.007199254740992E15");
            

}


}


}