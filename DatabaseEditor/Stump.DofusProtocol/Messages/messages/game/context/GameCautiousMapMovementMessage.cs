



















// Generated on 04/20/2016 12:03:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameCautiousMapMovementMessage : GameMapMovementMessage
{

public const ushort Id = 6497;
public override ushort MessageId
{
    get { return Id; }
}



public GameCautiousMapMovementMessage()
{
}

public GameCautiousMapMovementMessage(IEnumerable<short> keyMovements, double actorId)
         : base(keyMovements, actorId)
        {
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            

}


}


}