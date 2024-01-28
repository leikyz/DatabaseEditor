



















// Generated on 04/20/2016 12:04:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeErrorMessage : Message
{

public const ushort Id = 5513;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(errorType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

errorType = reader.ReadSByte();
            

}


}


}