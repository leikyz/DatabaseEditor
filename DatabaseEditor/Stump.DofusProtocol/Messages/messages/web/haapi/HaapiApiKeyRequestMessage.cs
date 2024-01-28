



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class HaapiApiKeyRequestMessage : Message
{

public const ushort Id = 6648;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte keyType;
        

public HaapiApiKeyRequestMessage()
{
}

public HaapiApiKeyRequestMessage(sbyte keyType)
        {
            this.keyType = keyType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(keyType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

keyType = reader.ReadSByte();
            if (keyType < 0)
                throw new Exception("Forbidden value on keyType = " + keyType + ", it doesn't respect the following condition : keyType < 0");
            

}


}


}