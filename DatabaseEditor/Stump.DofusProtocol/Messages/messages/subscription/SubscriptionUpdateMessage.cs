



















// Generated on 04/20/2016 12:04:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SubscriptionUpdateMessage : Message
{

public const ushort Id = 6616;
public override ushort MessageId
{
    get { return Id; }
}

public double timestamp;
        

public SubscriptionUpdateMessage()
{
}

public SubscriptionUpdateMessage(double timestamp)
        {
            this.timestamp = timestamp;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(timestamp);
            

}

public override void Deserialize(ICustomDataInput reader)
{

timestamp = reader.ReadDouble();
            if (timestamp < -9.007199254740992E15 || timestamp > 9.007199254740992E15)
                throw new Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < -9.007199254740992E15 || timestamp > 9.007199254740992E15");
            

}


}


}