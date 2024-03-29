



















// Generated on 04/20/2016 12:03:54
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PauseDialogMessage : Message
{

public const ushort Id = 6012;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte dialogType;
        

public PauseDialogMessage()
{
}

public PauseDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(dialogType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

dialogType = reader.ReadSByte();
            if (dialogType < 0)
                throw new Exception("Forbidden value on dialogType = " + dialogType + ", it doesn't respect the following condition : dialogType < 0");
            

}


}


}