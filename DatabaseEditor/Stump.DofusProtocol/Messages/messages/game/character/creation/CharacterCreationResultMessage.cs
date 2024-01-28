



















// Generated on 04/20/2016 12:03:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterCreationResultMessage : Message
{

public const ushort Id = 161;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte result;
        

public CharacterCreationResultMessage()
{
}

public CharacterCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(result);
            

}

public override void Deserialize(ICustomDataInput reader)
{

result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}