



















// Generated on 04/20/2016 12:03:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightReflectDamagesMessage : AbstractGameActionMessage
{

public const ushort Id = 5530;
public override ushort MessageId
{
    get { return Id; }
}

public double targetId;
        

public GameActionFightReflectDamagesMessage()
{
}

public GameActionFightReflectDamagesMessage(ushort actionId, double sourceId, double targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            

}


}


}