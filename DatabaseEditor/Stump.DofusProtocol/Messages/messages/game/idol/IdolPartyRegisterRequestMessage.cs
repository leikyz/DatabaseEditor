



















// Generated on 04/20/2016 12:04:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IdolPartyRegisterRequestMessage : Message
{

public const ushort Id = 6582;
public override ushort MessageId
{
    get { return Id; }
}

public bool register;
        

public IdolPartyRegisterRequestMessage()
{
}

public IdolPartyRegisterRequestMessage(bool register)
        {
            this.register = register;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(register);
            

}

public override void Deserialize(ICustomDataInput reader)
{

register = reader.ReadBoolean();
            

}


}


}