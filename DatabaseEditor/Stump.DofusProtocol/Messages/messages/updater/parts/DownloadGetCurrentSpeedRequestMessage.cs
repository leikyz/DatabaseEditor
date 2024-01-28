



















// Generated on 04/20/2016 12:04:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DownloadGetCurrentSpeedRequestMessage : Message
{

public const ushort Id = 1510;
public override ushort MessageId
{
    get { return Id; }
}



public DownloadGetCurrentSpeedRequestMessage()
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