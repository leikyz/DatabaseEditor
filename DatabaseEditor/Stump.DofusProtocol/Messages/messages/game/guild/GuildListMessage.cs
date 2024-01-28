



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildListMessage : Message
{

public const ushort Id = 6413;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<GuildInformations> guilds;
        

public GuildListMessage()
{
}

public GuildListMessage(IEnumerable<GuildInformations> guilds)
        {
            this.guilds = guilds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)guilds.Count());
            foreach (var entry in guilds)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            guilds = new GuildInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guilds as GuildInformations[])[i].Deserialize(reader);
            }
            

}


}


}