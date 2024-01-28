



















// Generated on 04/20/2016 12:04:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeCraftResultMessage : Message
{

public const ushort Id = 5790;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte craftResult;
        

public ExchangeCraftResultMessage()
{
}

public ExchangeCraftResultMessage(sbyte craftResult)
        {
            this.craftResult = craftResult;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(craftResult);
            

}

public override void Deserialize(ICustomDataInput reader)
{

craftResult = reader.ReadSByte();
            if (craftResult < 0)
                throw new Exception("Forbidden value on craftResult = " + craftResult + ", it doesn't respect the following condition : craftResult < 0");
            

}


}


}