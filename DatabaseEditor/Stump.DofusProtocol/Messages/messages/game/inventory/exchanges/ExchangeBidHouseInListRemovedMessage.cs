



















// Generated on 04/20/2016 12:04:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHouseInListRemovedMessage : Message
{

public const ushort Id = 5950;
public override ushort MessageId
{
    get { return Id; }
}

public int itemUID;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            this.itemUID = itemUID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(itemUID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

itemUID = reader.ReadInt();
            

}


}


}