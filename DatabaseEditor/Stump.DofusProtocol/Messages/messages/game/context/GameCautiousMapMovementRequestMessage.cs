



















// Generated on 04/20/2016 12:03:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameCautiousMapMovementRequestMessage : GameMapMovementRequestMessage
{

public const ushort Id = 6496;
public override ushort MessageId
{
    get { return Id; }
}



public GameCautiousMapMovementRequestMessage()
{
}

public GameCautiousMapMovementRequestMessage(IEnumerable<short> keyMovements, int mapId)
         : base(keyMovements, mapId)
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