



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildModificationNameValidMessage : Message
{

public const ushort Id = 6327;
public override ushort MessageId
{
    get { return Id; }
}

public string guildName;
        

public GuildModificationNameValidMessage()
{
}

public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(guildName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

guildName = reader.ReadUTF();
            

}


}


}