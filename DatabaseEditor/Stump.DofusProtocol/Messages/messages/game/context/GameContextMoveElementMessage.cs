



















// Generated on 04/20/2016 12:03:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameContextMoveElementMessage : Message
{

public const ushort Id = 253;
public override ushort MessageId
{
    get { return Id; }
}

public Types.EntityMovementInformations movement;
        

public GameContextMoveElementMessage()
{
}

public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

movement.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
            

}


}


}