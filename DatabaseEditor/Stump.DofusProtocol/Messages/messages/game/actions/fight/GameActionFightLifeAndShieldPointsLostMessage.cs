



















// Generated on 04/20/2016 12:03:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
{

public const ushort Id = 6310;
public override ushort MessageId
{
    get { return Id; }
}

public ushort shieldLoss;
        

public GameActionFightLifeAndShieldPointsLostMessage()
{
}

public GameActionFightLifeAndShieldPointsLostMessage(ushort actionId, double sourceId, double targetId, uint loss, uint permanentDamages, ushort shieldLoss)
         : base(actionId, sourceId, targetId, loss, permanentDamages)
        {
            this.shieldLoss = shieldLoss;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(shieldLoss);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            shieldLoss = reader.ReadVarUhShort();
            if (shieldLoss < 0)
                throw new Exception("Forbidden value on shieldLoss = " + shieldLoss + ", it doesn't respect the following condition : shieldLoss < 0");
            

}


}


}