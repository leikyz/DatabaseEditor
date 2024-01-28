



















// Generated on 04/20/2016 12:03:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightJoinRequestMessage : Message
{

public const ushort Id = 701;
public override ushort MessageId
{
    get { return Id; }
}

public double fighterId;
        public int fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(double fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(fighterId);
            writer.WriteInt(fightId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

fighterId = reader.ReadDouble();
            if (fighterId < -9.007199254740992E15 || fighterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on fighterId = " + fighterId + ", it doesn't respect the following condition : fighterId < -9.007199254740992E15 || fighterId > 9.007199254740992E15");
            fightId = reader.ReadInt();
            

}


}


}