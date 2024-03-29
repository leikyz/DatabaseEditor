



















// Generated on 04/20/2016 12:04:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class OnConnectionEventMessage : Message
{

public const ushort Id = 5726;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte eventType;
        

public OnConnectionEventMessage()
{
}

public OnConnectionEventMessage(sbyte eventType)
        {
            this.eventType = eventType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(eventType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

eventType = reader.ReadSByte();
            if (eventType < 0)
                throw new Exception("Forbidden value on eventType = " + eventType + ", it doesn't respect the following condition : eventType < 0");
            

}


}


}