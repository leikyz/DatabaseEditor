



















// Generated on 04/20/2016 12:04:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHouseListMessage : Message
{

public const ushort Id = 5807;
public override ushort MessageId
{
    get { return Id; }
}

public ushort id;
        

public ExchangeBidHouseListMessage()
{
}

public ExchangeBidHouseListMessage(ushort id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(id);
            

}

public override void Deserialize(ICustomDataInput reader)
{

id = reader.ReadVarUhShort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}