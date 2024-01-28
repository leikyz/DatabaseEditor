



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartOkNpcTradeMessage : Message
{

public const ushort Id = 5785;
public override ushort MessageId
{
    get { return Id; }
}

public double npcId;
        

public ExchangeStartOkNpcTradeMessage()
{
}

public ExchangeStartOkNpcTradeMessage(double npcId)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(npcId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

npcId = reader.ReadDouble();
            if (npcId < -9.007199254740992E15 || npcId > 9.007199254740992E15)
                throw new Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < -9.007199254740992E15 || npcId > 9.007199254740992E15");
            

}


}


}