



















// Generated on 04/20/2016 12:03:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AchievementDetailedListMessage : Message
{

public const ushort Id = 6358;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Achievement> startedAchievements;
        public IEnumerable<Achievement> finishedAchievements;
        

public AchievementDetailedListMessage()
{
}

public AchievementDetailedListMessage(IEnumerable<Achievement> startedAchievements, IEnumerable<Achievement> finishedAchievements)
        {
            this.startedAchievements = startedAchievements;
            this.finishedAchievements = finishedAchievements;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)startedAchievements.Count());
            foreach (var entry in startedAchievements)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)finishedAchievements.Count());
            foreach (var entry in finishedAchievements)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            startedAchievements = new Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (startedAchievements as Achievement[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            finishedAchievements = new Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedAchievements as Achievement[])[i].Deserialize(reader);
            }
            

}


}


}