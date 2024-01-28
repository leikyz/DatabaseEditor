



















// Generated on 04/20/2016 12:03:38
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class HouseGuildNoneMessage : Message
{

public const ushort Id = 5701;
public override ushort MessageId
{
    get { return Id; }
}

public uint houseId;
        

public HouseGuildNoneMessage()
{
}

public HouseGuildNoneMessage(uint houseId)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(houseId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

houseId = reader.ReadVarUhInt();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}