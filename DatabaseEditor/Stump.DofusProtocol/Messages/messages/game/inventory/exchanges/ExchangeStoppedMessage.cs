



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStoppedMessage : Message
{

public const ushort Id = 6589;
public override ushort MessageId
{
    get { return Id; }
}

public ulong id;
        

public ExchangeStoppedMessage()
{
}

public ExchangeStoppedMessage(ulong id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(id);
            

}

public override void Deserialize(ICustomDataInput reader)
{

id = reader.ReadVarUhLong();
            if (id < 0 || id > 9.007199254740992E15)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0 || id > 9.007199254740992E15");
            

}


}


}