



















// Generated on 04/20/2016 12:04:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PrismUseRequestMessage : Message
{

public const ushort Id = 6041;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte moduleToUse;
        

public PrismUseRequestMessage()
{
}

public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(moduleToUse);
            

}

public override void Deserialize(ICustomDataInput reader)
{

moduleToUse = reader.ReadSByte();
            if (moduleToUse < 0)
                throw new Exception("Forbidden value on moduleToUse = " + moduleToUse + ", it doesn't respect the following condition : moduleToUse < 0");
            

}


}


}