



















// Generated on 04/20/2016 12:04:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SetCharacterRestrictionsMessage : Message
{

public const ushort Id = 170;
public override ushort MessageId
{
    get { return Id; }
}

public double actorId;
        public Types.ActorRestrictionsInformations restrictions;
        

public SetCharacterRestrictionsMessage()
{
}

public SetCharacterRestrictionsMessage(double actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(actorId);
            restrictions.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

actorId = reader.ReadDouble();
            if (actorId < -9.007199254740992E15 || actorId > 9.007199254740992E15)
                throw new Exception("Forbidden value on actorId = " + actorId + ", it doesn't respect the following condition : actorId < -9.007199254740992E15 || actorId > 9.007199254740992E15");
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            

}


}


}