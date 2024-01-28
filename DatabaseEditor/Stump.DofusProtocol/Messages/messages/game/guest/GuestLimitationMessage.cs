



















// Generated on 04/20/2016 12:03:56
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuestLimitationMessage : Message
{

public const ushort Id = 6506;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public GuestLimitationMessage()
{
}

public GuestLimitationMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataInput reader)
{

reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}