



















// Generated on 04/20/2016 12:44:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class ObjectEffectInteger : ObjectEffect
{

public const short Id = 70;
public override short TypeId
{
    get { return Id; }
}

public ushort value;
        

public ObjectEffectInteger()
{
}

public ObjectEffectInteger(ushort actionId, ushort value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(value);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            value = reader.ReadVarUhShort();
            if (value < 0)
                throw new Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < 0");
            

}


}


}