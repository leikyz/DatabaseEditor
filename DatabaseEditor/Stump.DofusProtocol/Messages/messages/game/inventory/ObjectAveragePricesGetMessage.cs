



















// Generated on 04/20/2016 12:04:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectAveragePricesGetMessage : Message
{

public const ushort Id = 6334;
public override ushort MessageId
{
    get { return Id; }
}



public ObjectAveragePricesGetMessage()
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