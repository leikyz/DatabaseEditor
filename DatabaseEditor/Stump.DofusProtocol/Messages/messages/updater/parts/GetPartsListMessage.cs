



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GetPartsListMessage : Message
{

public const ushort Id = 1501;
public override ushort MessageId
{
    get { return Id; }
}



public GetPartsListMessage()
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