



















// Generated on 04/20/2016 12:04:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHouseItemRemoveOkMessage : Message
{

public const ushort Id = 5946;
public override ushort MessageId
{
    get { return Id; }
}

public int sellerId;
        

public ExchangeBidHouseItemRemoveOkMessage()
{
}

public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
        {
            this.sellerId = sellerId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(sellerId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

sellerId = reader.ReadInt();
            

}


}


}