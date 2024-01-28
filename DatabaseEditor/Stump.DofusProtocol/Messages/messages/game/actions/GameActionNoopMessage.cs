



















// Generated on 04/20/2016 12:03:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionNoopMessage : Message
{

public const ushort Id = 1002;
public override ushort MessageId
{
    get { return Id; }
}



public GameActionNoopMessage()
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