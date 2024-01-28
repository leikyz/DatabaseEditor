



















// Generated on 04/20/2016 12:04:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeReplayStopMessage : Message
{

public const ushort Id = 6001;
public override ushort MessageId
{
    get { return Id; }
}



public ExchangeReplayStopMessage()
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