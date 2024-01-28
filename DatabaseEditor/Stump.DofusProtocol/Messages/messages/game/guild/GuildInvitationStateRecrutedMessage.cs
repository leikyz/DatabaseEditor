



















// Generated on 04/20/2016 12:03:58
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildInvitationStateRecrutedMessage : Message
{

public const ushort Id = 5548;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public GuildInvitationStateRecrutedMessage()
{
}

public GuildInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(invitationState);
            

}

public override void Deserialize(ICustomDataInput reader)
{

invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}