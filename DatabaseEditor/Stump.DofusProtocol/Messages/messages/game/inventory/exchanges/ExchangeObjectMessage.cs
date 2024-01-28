



















// Generated on 04/20/2016 12:04:09
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeObjectMessage : Message
{

public const ushort Id = 5515;
public override ushort MessageId
{
    get { return Id; }
}

public bool remote;
        

public ExchangeObjectMessage()
{
}

public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(remote);
            

}

public override void Deserialize(ICustomDataInput reader)
{

remote = reader.ReadBoolean();
            

}


}


}