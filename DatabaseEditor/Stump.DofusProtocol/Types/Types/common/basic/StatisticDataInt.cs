



















// Generated on 04/20/2016 12:44:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class StatisticDataInt : StatisticData
{

public const short Id = 485;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public StatisticDataInt()
{
}

public StatisticDataInt(int value)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}