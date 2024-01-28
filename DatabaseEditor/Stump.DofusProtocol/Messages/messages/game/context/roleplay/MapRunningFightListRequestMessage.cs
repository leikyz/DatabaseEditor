



















// Generated on 04/20/2016 12:03:32
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MapRunningFightListRequestMessage : Message
{

public const ushort Id = 5742;
public override ushort MessageId
{
    get { return Id; }
}



public MapRunningFightListRequestMessage()
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