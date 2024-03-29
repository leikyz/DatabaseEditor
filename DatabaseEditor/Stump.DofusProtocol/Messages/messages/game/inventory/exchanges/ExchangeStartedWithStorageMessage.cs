



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
{

public const ushort Id = 6236;
public override ushort MessageId
{
    get { return Id; }
}

public uint storageMaxSlot;
        

public ExchangeStartedWithStorageMessage()
{
}

public ExchangeStartedWithStorageMessage(sbyte exchangeType, uint storageMaxSlot)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhInt(storageMaxSlot);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            storageMaxSlot = reader.ReadVarUhInt();
            if (storageMaxSlot < 0)
                throw new Exception("Forbidden value on storageMaxSlot = " + storageMaxSlot + ", it doesn't respect the following condition : storageMaxSlot < 0");
            

}


}


}