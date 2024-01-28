



















// Generated on 04/20/2016 12:04:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MimicryObjectAssociatedMessage : SymbioticObjectAssociatedMessage
{

public const ushort Id = 6462;
public override ushort MessageId
{
    get { return Id; }
}



public MimicryObjectAssociatedMessage()
{
}

public MimicryObjectAssociatedMessage(uint hostUID)
         : base(hostUID)
        {
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            

}


}


}