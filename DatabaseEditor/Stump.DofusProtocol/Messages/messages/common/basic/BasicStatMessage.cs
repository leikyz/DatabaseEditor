



















// Generated on 04/20/2016 12:03:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class BasicStatMessage : Message
{

public const ushort Id = 6530;
public override ushort MessageId
{
    get { return Id; }
}

public double timeSpent;
        public ushort statId;
        

public BasicStatMessage()
{
}

public BasicStatMessage(double timeSpent, ushort statId)
        {
            this.timeSpent = timeSpent;
            this.statId = statId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(timeSpent);
            writer.WriteVarUhShort(statId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

timeSpent = reader.ReadDouble();
            if (timeSpent < 0 || timeSpent > 9.007199254740992E15)
                throw new Exception("Forbidden value on timeSpent = " + timeSpent + ", it doesn't respect the following condition : timeSpent < 0 || timeSpent > 9.007199254740992E15");
            statId = reader.ReadVarUhShort();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            

}


}


}