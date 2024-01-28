



















// Generated on 04/20/2016 12:03:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
{

public const ushort Id = 6541;
public override ushort MessageId
{
    get { return Id; }
}

public double requestedId;
        

public GameFightPlacementSwapPositionsRequestMessage()
{
}

public GameFightPlacementSwapPositionsRequestMessage(ushort cellId, double requestedId)
         : base(cellId)
        {
            this.requestedId = requestedId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteDouble(requestedId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            requestedId = reader.ReadDouble();
            if (requestedId < -9.007199254740992E15 || requestedId > 9.007199254740992E15)
                throw new Exception("Forbidden value on requestedId = " + requestedId + ", it doesn't respect the following condition : requestedId < -9.007199254740992E15 || requestedId > 9.007199254740992E15");
            

}


}


}