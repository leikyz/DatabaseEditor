



















// Generated on 04/20/2016 12:03:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage
{

public const ushort Id = 5828;
public override ushort MessageId
{
    get { return Id; }
}

public double targetId;
        public ushort amount;
        

public GameActionFightDodgePointLossMessage()
{
}

public GameActionFightDodgePointLossMessage(ushort actionId, double sourceId, double targetId, ushort amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarUhShort(amount);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            amount = reader.ReadVarUhShort();
            if (amount < 0)
                throw new Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
            

}


}


}