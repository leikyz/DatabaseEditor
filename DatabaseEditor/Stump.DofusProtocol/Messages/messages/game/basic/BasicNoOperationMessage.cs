



















// Generated on 04/20/2016 12:03:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class BasicNoOperationMessage : Message
{

public const ushort Id = 176;
public override ushort MessageId
{
    get { return Id; }
}



public BasicNoOperationMessage()
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