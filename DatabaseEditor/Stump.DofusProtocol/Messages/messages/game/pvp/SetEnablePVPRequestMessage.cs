



















// Generated on 04/20/2016 12:04:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SetEnablePVPRequestMessage : Message
{

public const ushort Id = 1810;
public override ushort MessageId
{
    get { return Id; }
}

public bool enable;
        

public SetEnablePVPRequestMessage()
{
}

public SetEnablePVPRequestMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(ICustomDataInput reader)
{

enable = reader.ReadBoolean();
            

}


}


}