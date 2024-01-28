



















// Generated on 04/20/2016 12:04:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeCraftCountRequestMessage : Message
{

public const ushort Id = 6597;
public override ushort MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeCraftCountRequestMessage()
{
}

public ExchangeCraftCountRequestMessage(int count)
        {
            this.count = count;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarInt(count);
            

}

public override void Deserialize(ICustomDataInput reader)
{

count = reader.ReadVarInt();
            

}


}


}