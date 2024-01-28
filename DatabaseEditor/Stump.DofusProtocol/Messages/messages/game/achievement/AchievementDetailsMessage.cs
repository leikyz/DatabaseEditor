



















// Generated on 04/20/2016 12:03:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AchievementDetailsMessage : Message
{

public const ushort Id = 6378;
public override ushort MessageId
{
    get { return Id; }
}

public Types.Achievement achievement;
        

public AchievementDetailsMessage()
{
}

public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

achievement.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

achievement = new Types.Achievement();
            achievement.Deserialize(reader);
            

}


}


}