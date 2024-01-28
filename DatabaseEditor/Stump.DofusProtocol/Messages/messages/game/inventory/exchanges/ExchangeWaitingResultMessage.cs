



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeWaitingResultMessage : Message
{

public const ushort Id = 5786;
public override ushort MessageId
{
    get { return Id; }
}

public bool bwait;
        

public ExchangeWaitingResultMessage()
{
}

public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(bwait);
            

}

public override void Deserialize(ICustomDataInput reader)
{

bwait = reader.ReadBoolean();
            

}


}


}