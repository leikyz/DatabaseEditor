



















// Generated on 04/20/2016 12:04:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
{

public const ushort Id = 5523;
public override ushort MessageId
{
    get { return Id; }
}

public ulong source;
        public ulong target;
        

public ExchangeRequestedTradeMessage()
{
}

public ExchangeRequestedTradeMessage(sbyte exchangeType, ulong source, ulong target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(source);
            writer.WriteVarUhLong(target);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            source = reader.ReadVarUhLong();
            if (source < 0 || source > 9.007199254740992E15)
                throw new Exception("Forbidden value on source = " + source + ", it doesn't respect the following condition : source < 0 || source > 9.007199254740992E15");
            target = reader.ReadVarUhLong();
            if (target < 0 || target > 9.007199254740992E15)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0 || target > 9.007199254740992E15");
            

}


}


}