



















// Generated on 04/20/2016 12:03:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
{

public const ushort Id = 6312;
public override ushort MessageId
{
    get { return Id; }
}

public double targetId;
        public uint loss;
        public uint permanentDamages;
        

public GameActionFightLifePointsLostMessage()
{
}

public GameActionFightLifePointsLostMessage(ushort actionId, double sourceId, double targetId, uint loss, uint permanentDamages)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.loss = loss;
            this.permanentDamages = permanentDamages;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarUhInt(loss);
            writer.WriteVarUhInt(permanentDamages);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            loss = reader.ReadVarUhInt();
            if (loss < 0)
                throw new Exception("Forbidden value on loss = " + loss + ", it doesn't respect the following condition : loss < 0");
            permanentDamages = reader.ReadVarUhInt();
            if (permanentDamages < 0)
                throw new Exception("Forbidden value on permanentDamages = " + permanentDamages + ", it doesn't respect the following condition : permanentDamages < 0");
            

}


}


}