



















// Generated on 04/20/2016 12:03:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AggregateStatMessage : Message
{

public const ushort Id = 6669;
public override ushort MessageId
{
    get { return Id; }
}

public ushort statId;
        

public AggregateStatMessage()
{
}

public AggregateStatMessage(ushort statId)
        {
            this.statId = statId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(statId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

statId = reader.ReadVarUhShort();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            

}


}


}