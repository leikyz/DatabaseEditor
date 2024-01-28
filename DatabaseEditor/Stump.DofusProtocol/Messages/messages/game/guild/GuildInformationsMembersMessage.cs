



















// Generated on 04/20/2016 12:03:57
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildInformationsMembersMessage : Message
{

public const ushort Id = 5558;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<GuildMember> members;
        

public GuildInformationsMembersMessage()
{
}

public GuildInformationsMembersMessage(IEnumerable<GuildMember> members)
        {
            this.members = members;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)members.Count());
            foreach (var entry in members)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            members = new GuildMember[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as GuildMember[])[i].Deserialize(reader);
            }
            

}


}


}