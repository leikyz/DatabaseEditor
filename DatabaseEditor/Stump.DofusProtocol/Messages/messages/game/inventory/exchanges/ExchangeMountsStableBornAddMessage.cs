



















// Generated on 04/20/2016 12:04:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
{

public const ushort Id = 6557;
public override ushort MessageId
{
    get { return Id; }
}



public ExchangeMountsStableBornAddMessage()
{
}

public ExchangeMountsStableBornAddMessage(IEnumerable<MountClientData> mountDescription)
         : base(mountDescription)
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