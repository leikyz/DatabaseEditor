



















// Generated on 04/20/2016 12:03:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightLeaveMessage : Message
{

public const ushort Id = 721;
public override ushort MessageId
{
    get { return Id; }
}

public double charId;
        

public GameFightLeaveMessage()
{
}

public GameFightLeaveMessage(double charId)
        {
            this.charId = charId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(charId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

charId = reader.ReadDouble();
            if (charId < -9.007199254740992E15 || charId > 9.007199254740992E15)
                throw new Exception("Forbidden value on charId = " + charId + ", it doesn't respect the following condition : charId < -9.007199254740992E15 || charId > 9.007199254740992E15");
            

}


}


}