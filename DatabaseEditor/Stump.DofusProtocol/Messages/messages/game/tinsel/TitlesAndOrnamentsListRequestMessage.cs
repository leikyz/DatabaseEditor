



















// Generated on 04/20/2016 12:04:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TitlesAndOrnamentsListRequestMessage : Message
{

public const ushort Id = 6363;
public override ushort MessageId
{
    get { return Id; }
}



public TitlesAndOrnamentsListRequestMessage()
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