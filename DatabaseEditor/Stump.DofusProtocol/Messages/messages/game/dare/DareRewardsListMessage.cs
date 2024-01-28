



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareRewardsListMessage : Message
{

public const ushort Id = 6677;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<DareReward> rewards;
        

public DareRewardsListMessage()
{
}

public DareRewardsListMessage(IEnumerable<DareReward> rewards)
        {
            this.rewards = rewards;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)rewards.Count());
            foreach (var entry in rewards)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            rewards = new DareReward[limit];
            for (int i = 0; i < limit; i++)
            {
                 (rewards as DareReward[])[i].Deserialize(reader);
            }
            

}


}


}