



















// Generated on 04/20/2016 12:03:30
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MountSterilizeRequestMessage : Message
{

public const ushort Id = 5962;
public override ushort MessageId
{
    get { return Id; }
}



public MountSterilizeRequestMessage()
{
}



public override void Serialize(ICustomDataOutput writer)
{



}

public override void Deserialize(ICustomDataInput reader)
{



}


}


}