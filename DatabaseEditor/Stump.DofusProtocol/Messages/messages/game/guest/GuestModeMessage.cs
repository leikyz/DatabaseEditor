



















// Generated on 04/20/2016 12:03:56
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuestModeMessage : Message
{

public const ushort Id = 6505;
public override ushort MessageId
{
    get { return Id; }
}

public bool active;
        

public GuestModeMessage()
{
}

public GuestModeMessage(bool active)
        {
            this.active = active;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(active);
            

}

public override void Deserialize(ICustomDataInput reader)
{

active = reader.ReadBoolean();
            

}


}


}