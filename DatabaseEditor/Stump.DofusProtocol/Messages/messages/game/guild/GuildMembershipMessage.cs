



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildMembershipMessage : GuildJoinedMessage
{

public const ushort Id = 5835;
public override ushort MessageId
{
    get { return Id; }
}



public GuildMembershipMessage()
{
}

public GuildMembershipMessage(Types.GuildInformations guildInfo, uint memberRights, bool enabled)
         : base(guildInfo, memberRights, enabled)
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