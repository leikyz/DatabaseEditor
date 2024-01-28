



















// Generated on 04/20/2016 12:04:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeBidHouseGenericItemAddedMessage : Message
{

public const ushort Id = 5947;
public override ushort MessageId
{
    get { return Id; }
}

public ushort objGenericId;
        

public ExchangeBidHouseGenericItemAddedMessage()
{
}

public ExchangeBidHouseGenericItemAddedMessage(ushort objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(objGenericId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

objGenericId = reader.ReadVarUhShort();
            if (objGenericId < 0)
                throw new Exception("Forbidden value on objGenericId = " + objGenericId + ", it doesn't respect the following condition : objGenericId < 0");
            

}


}


}