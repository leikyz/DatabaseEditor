



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartedMessage : Message
{

public const ushort Id = 5512;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeStartedMessage()
{
}

public ExchangeStartedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(exchangeType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

exchangeType = reader.ReadSByte();
            

}


}


}