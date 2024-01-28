



















// Generated on 04/20/2016 12:44:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GuildFactSheetInformations : GuildInformations
{

public const short Id = 424;
public override short TypeId
{
    get { return Id; }
}

public ulong leaderId;
        public ushort nbMembers;
        

public GuildFactSheetInformations()
{
}

public GuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, ulong leaderId, ushort nbMembers)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.leaderId = leaderId;
            this.nbMembers = nbMembers;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(leaderId);
            writer.WriteVarUhShort(nbMembers);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            leaderId = reader.ReadVarUhLong();
            if (leaderId < 0 || leaderId > 9.007199254740992E15)
                throw new Exception("Forbidden value on leaderId = " + leaderId + ", it doesn't respect the following condition : leaderId < 0 || leaderId > 9.007199254740992E15");
            nbMembers = reader.ReadVarUhShort();
            if (nbMembers < 0)
                throw new Exception("Forbidden value on nbMembers = " + nbMembers + ", it doesn't respect the following condition : nbMembers < 0");
            

}


}


}