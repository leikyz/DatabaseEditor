



















// Generated on 04/20/2016 12:03:28
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightShowFighterRandomStaticPoseMessage : GameFightShowFighterMessage
{

public const ushort Id = 6218;
public override ushort MessageId
{
    get { return Id; }
}



public GameFightShowFighterRandomStaticPoseMessage()
{
}

public GameFightShowFighterRandomStaticPoseMessage(Types.GameFightFighterInformations informations)
         : base(informations)
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