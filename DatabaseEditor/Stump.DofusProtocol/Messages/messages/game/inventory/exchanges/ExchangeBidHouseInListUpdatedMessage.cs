



















// Generated on 04/20/2016 12:04:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHouseInListUpdatedMessage : ExchangeBidHouseInListAddedMessage
{

public const ushort Id = 6337;
public override ushort MessageId
{
    get { return Id; }
}



public ExchangeBidHouseInListUpdatedMessage()
{
}

public ExchangeBidHouseInListUpdatedMessage(int itemUID, int objGenericId, IEnumerable<Types.ObjectEffect> effects, IEnumerable<uint> prices)
         : base(itemUID, objGenericId, effects, prices)
        {
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            

}


}


}