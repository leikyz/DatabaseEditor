



















// Generated on 04/20/2016 12:03:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class FriendGuildWarnOnAchievementCompleteStateMessage : Message
{

public const ushort Id = 6383;
public override ushort MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendGuildWarnOnAchievementCompleteStateMessage()
{
}

public FriendGuildWarnOnAchievementCompleteStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(ICustomDataInput reader)
{

enable = reader.ReadBoolean();
            

}


}


}