



















// Generated on 04/20/2016 12:04:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeReplyTaxVendorMessage : Message
{

public const ushort Id = 5787;
public override ushort MessageId
{
    get { return Id; }
}

public uint objectValue;
        public uint totalTaxValue;
        

public ExchangeReplyTaxVendorMessage()
{
}

public ExchangeReplyTaxVendorMessage(uint objectValue, uint totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(objectValue);
            writer.WriteVarUhInt(totalTaxValue);
            

}

public override void Deserialize(ICustomDataInput reader)
{

objectValue = reader.ReadVarUhInt();
            if (objectValue < 0)
                throw new Exception("Forbidden value on objectValue = " + objectValue + ", it doesn't respect the following condition : objectValue < 0");
            totalTaxValue = reader.ReadVarUhInt();
            if (totalTaxValue < 0)
                throw new Exception("Forbidden value on totalTaxValue = " + totalTaxValue + ", it doesn't respect the following condition : totalTaxValue < 0");
            

}


}


}