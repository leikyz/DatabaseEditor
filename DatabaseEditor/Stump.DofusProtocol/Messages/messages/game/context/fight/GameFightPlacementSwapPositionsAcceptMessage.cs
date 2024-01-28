



















// Generated on 04/20/2016 12:03:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightPlacementSwapPositionsAcceptMessage : Message
{

public const ushort Id = 6547;
public override ushort MessageId
{
    get { return Id; }
}

public int requestId;
        

public GameFightPlacementSwapPositionsAcceptMessage()
{
}

public GameFightPlacementSwapPositionsAcceptMessage(int requestId)
        {
            this.requestId = requestId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(requestId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

requestId = reader.ReadInt();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            

}


}


}