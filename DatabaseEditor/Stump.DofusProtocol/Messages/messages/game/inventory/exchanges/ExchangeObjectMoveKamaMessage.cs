



















// Generated on 04/20/2016 12:04:09
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeObjectMoveKamaMessage : Message
{

public const ushort Id = 5520;
public override ushort MessageId
{
    get { return Id; }
}

public int quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(int quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarInt(quantity);
            

}

public override void Deserialize(ICustomDataInput reader)
{

quantity = reader.ReadVarInt();
            

}


}


}