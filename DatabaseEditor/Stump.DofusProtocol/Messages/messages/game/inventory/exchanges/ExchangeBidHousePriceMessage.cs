



















// Generated on 04/20/2016 12:04:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHousePriceMessage : Message
{

public const ushort Id = 5805;
public override ushort MessageId
{
    get { return Id; }
}

public ushort genId;
        

public ExchangeBidHousePriceMessage()
{
}

public ExchangeBidHousePriceMessage(ushort genId)
        {
            this.genId = genId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(genId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

genId = reader.ReadVarUhShort();
            if (genId < 0)
                throw new Exception("Forbidden value on genId = " + genId + ", it doesn't respect the following condition : genId < 0");
            

}


}


}