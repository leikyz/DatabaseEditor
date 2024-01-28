



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildMemberOnlineStatusMessage : Message
{

public const ushort Id = 6061;
public override ushort MessageId
{
    get { return Id; }
}

public ulong memberId;
        public bool online;
        

public GuildMemberOnlineStatusMessage()
{
}

public GuildMemberOnlineStatusMessage(ulong memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(memberId);
            writer.WriteBoolean(online);
            

}

public override void Deserialize(ICustomDataInput reader)
{

memberId = reader.ReadVarUhLong();
            if (memberId < 0 || memberId > 9.007199254740992E15)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0 || memberId > 9.007199254740992E15");
            online = reader.ReadBoolean();
            

}


}


}