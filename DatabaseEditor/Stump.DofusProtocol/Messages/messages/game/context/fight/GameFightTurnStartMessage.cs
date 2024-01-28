



















// Generated on 04/20/2016 12:03:27
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightTurnStartMessage : Message
{

public const ushort Id = 714;
public override ushort MessageId
{
    get { return Id; }
}

public double id;
        public uint waitTime;
        

public GameFightTurnStartMessage()
{
}

public GameFightTurnStartMessage(double id, uint waitTime)
        {
            this.id = id;
            this.waitTime = waitTime;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(id);
            writer.WriteVarUhInt(waitTime);
            

}

public override void Deserialize(ICustomDataInput reader)
{

id = reader.ReadDouble();
            if (id < -9.007199254740992E15 || id > 9.007199254740992E15)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < -9.007199254740992E15 || id > 9.007199254740992E15");
            waitTime = reader.ReadVarUhInt();
            if (waitTime < 0)
                throw new Exception("Forbidden value on waitTime = " + waitTime + ", it doesn't respect the following condition : waitTime < 0");
            

}


}


}