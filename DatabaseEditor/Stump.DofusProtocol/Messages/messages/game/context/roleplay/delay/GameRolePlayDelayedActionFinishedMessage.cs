



















// Generated on 04/20/2016 12:03:33
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayDelayedActionFinishedMessage : Message
{

public const ushort Id = 6150;
public override ushort MessageId
{
    get { return Id; }
}

public double delayedCharacterId;
        public sbyte delayTypeId;
        

public GameRolePlayDelayedActionFinishedMessage()
{
}

public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, sbyte delayTypeId)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(delayedCharacterId);
            writer.WriteSByte(delayTypeId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

delayedCharacterId = reader.ReadDouble();
            if (delayedCharacterId < -9.007199254740992E15 || delayedCharacterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on delayedCharacterId = " + delayedCharacterId + ", it doesn't respect the following condition : delayedCharacterId < -9.007199254740992E15 || delayedCharacterId > 9.007199254740992E15");
            delayTypeId = reader.ReadSByte();
            if (delayTypeId < 0)
                throw new Exception("Forbidden value on delayTypeId = " + delayTypeId + ", it doesn't respect the following condition : delayTypeId < 0");
            

}


}


}