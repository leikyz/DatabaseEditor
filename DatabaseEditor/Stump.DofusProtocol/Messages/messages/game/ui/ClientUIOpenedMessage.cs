



















// Generated on 04/20/2016 12:04:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ClientUIOpenedMessage : Message
{

public const ushort Id = 6459;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte type;
        

public ClientUIOpenedMessage()
{
}

public ClientUIOpenedMessage(sbyte type)
        {
            this.type = type;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(type);
            

}

public override void Deserialize(ICustomDataInput reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}