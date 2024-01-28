



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareRewardWonMessage : Message
{

public const ushort Id = 6678;
public override ushort MessageId
{
    get { return Id; }
}

public Types.DareReward reward;
        

public DareRewardWonMessage()
{
}

public DareRewardWonMessage(Types.DareReward reward)
        {
            this.reward = reward;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

reward.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

reward = new Types.DareReward();
            reward.Deserialize(reader);
            

}


}


}