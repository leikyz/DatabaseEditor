



















// Generated on 04/20/2016 12:04:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class LoginQueueStatusMessage : Message
{

public const ushort Id = 10;
public override ushort MessageId
{
    get { return Id; }
}

public ushort position;
        public ushort total;
        

public LoginQueueStatusMessage()
{
}

public LoginQueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort(position);
            writer.WriteUShort(total);
            

}

public override void Deserialize(ICustomDataInput reader)
{

position = reader.ReadUShort();
            if (position < 0 || position > 65535)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 65535");
            total = reader.ReadUShort();
            if (total < 0 || total > 65535)
                throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0 || total > 65535");
            

}


}


}