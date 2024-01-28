



















// Generated on 04/20/2016 12:03:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightTurnEndMessage : Message
{

public const ushort Id = 719;
public override ushort MessageId
{
    get { return Id; }
}

public double id;
        

public GameFightTurnEndMessage()
{
}

public GameFightTurnEndMessage(double id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(id);
            

}

public override void Deserialize(ICustomDataInput reader)
{

id = reader.ReadDouble();
            if (id < -9.007199254740992E15 || id > 9.007199254740992E15)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < -9.007199254740992E15 || id > 9.007199254740992E15");
            

}


}


}