



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildModificationEmblemValidMessage : Message
{

public const ushort Id = 6328;
public override ushort MessageId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildModificationEmblemValidMessage()
{
}

public GuildModificationEmblemValidMessage(Types.GuildEmblem guildEmblem)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

guildEmblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}