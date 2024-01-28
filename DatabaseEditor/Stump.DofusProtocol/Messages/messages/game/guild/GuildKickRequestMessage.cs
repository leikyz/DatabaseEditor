



















// Generated on 04/20/2016 12:03:58
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildKickRequestMessage : Message
{

public const ushort Id = 5887;
public override ushort MessageId
{
    get { return Id; }
}

public ulong kickedId;
        

public GuildKickRequestMessage()
{
}

public GuildKickRequestMessage(ulong kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(kickedId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

kickedId = reader.ReadVarUhLong();
            if (kickedId < 0 || kickedId > 9.007199254740992E15)
                throw new Exception("Forbidden value on kickedId = " + kickedId + ", it doesn't respect the following condition : kickedId < 0 || kickedId > 9.007199254740992E15");
            

}


}


}