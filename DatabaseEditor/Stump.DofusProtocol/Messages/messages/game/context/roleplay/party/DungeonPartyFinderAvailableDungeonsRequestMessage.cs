



















// Generated on 04/20/2016 12:03:44
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DungeonPartyFinderAvailableDungeonsRequestMessage : Message
{

public const ushort Id = 6240;
public override ushort MessageId
{
    get { return Id; }
}



public DungeonPartyFinderAvailableDungeonsRequestMessage()
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