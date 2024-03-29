



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildModificationValidMessage : Message
{

public const ushort Id = 6323;
public override ushort MessageId
{
    get { return Id; }
}

public string guildName;
        public Types.GuildEmblem guildEmblem;
        

public GuildModificationValidMessage()
{
}

public GuildModificationValidMessage(string guildName, Types.GuildEmblem guildEmblem)
        {
            this.guildName = guildName;
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(guildName);
            guildEmblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

guildName = reader.ReadUTF();
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}