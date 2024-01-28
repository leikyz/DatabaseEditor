



















// Generated on 04/20/2016 12:04:22
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ShortcutBarRemoveErrorMessage : Message
{

public const ushort Id = 6222;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarRemoveErrorMessage()
{
}

public ShortcutBarRemoveErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(error);
            

}

public override void Deserialize(ICustomDataInput reader)
{

error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            

}


}


}