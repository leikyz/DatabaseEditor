



















// Generated on 04/20/2016 12:04:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeCraftCountModifiedMessage : Message
{

public const ushort Id = 6595;
public override ushort MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeCraftCountModifiedMessage()
{
}

public ExchangeCraftCountModifiedMessage(int count)
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