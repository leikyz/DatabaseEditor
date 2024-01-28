



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : Message
{

public const ushort Id = 6021;
public override ushort MessageId
{
    get { return Id; }
}

public bool allow;
        

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(allow);
            

}

public override void Deserialize(ICustomDataInput reader)
{

allow = reader.ReadBoolean();
            

}


}


}