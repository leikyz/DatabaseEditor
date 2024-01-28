



















// Generated on 04/20/2016 12:04:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeCrafterJobLevelupMessage : Message
{

public const ushort Id = 6598;
public override ushort MessageId
{
    get { return Id; }
}

public byte crafterJobLevel;
        

public ExchangeCrafterJobLevelupMessage()
{
}

public ExchangeCrafterJobLevelupMessage(byte crafterJobLevel)
        {
            this.crafterJobLevel = crafterJobLevel;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteByte(crafterJobLevel);
            

}

public override void Deserialize(ICustomDataInput reader)
{

crafterJobLevel = reader.ReadByte();
            if (crafterJobLevel < 0 || crafterJobLevel > 255)
                throw new Exception("Forbidden value on crafterJobLevel = " + crafterJobLevel + ", it doesn't respect the following condition : crafterJobLevel < 0 || crafterJobLevel > 255");
            

}


}


}