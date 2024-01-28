



















// Generated on 04/20/2016 12:03:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AchievementListMessage : Message
{

public const ushort Id = 6205;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> finishedAchievementsIds;
        public IEnumerable<AchievementRewardable> rewardableAchievements;
        

public AchievementListMessage()
{
}

public AchievementListMessage(IEnumerable<ushort> finishedAchievementsIds, IEnumerable<AchievementRewardable> rewardableAchievements)
        {
            this.finishedAchievementsIds = finishedAchievementsIds;
            this.rewardableAchievements = rewardableAchievements;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)finishedAchievementsIds.Count());
            foreach (var entry in finishedAchievementsIds)
            {
                 writer.WriteVarUhShort(entry);
            }
            writer.WriteUShort((ushort)rewardableAchievements.Count());
            foreach (var entry in rewardableAchievements)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            finishedAchievementsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedAchievementsIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            rewardableAchievements = new AchievementRewardable[limit];
            for (int i = 0; i < limit; i++)
            {
                 (rewardableAchievements as AchievementRewardable[])[i].Deserialize(reader);
            }
            

}


}


}