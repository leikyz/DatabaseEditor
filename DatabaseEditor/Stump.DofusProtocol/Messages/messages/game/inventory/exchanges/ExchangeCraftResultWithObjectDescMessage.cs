



















// Generated on 04/20/2016 12:04:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
{

public const ushort Id = 5999;
public override ushort MessageId
{
    get { return Id; }
}

public Types.ObjectItemNotInContainer objectInfo;
        

public ExchangeCraftResultWithObjectDescMessage()
{
}

public ExchangeCraftResultWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo)
         : base(craftResult)
        {
            this.objectInfo = objectInfo;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            objectInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            objectInfo = new Types.ObjectItemNotInContainer();
            objectInfo.Deserialize(reader);
            

}


}


}