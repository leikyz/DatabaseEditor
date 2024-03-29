



















// Generated on 04/20/2016 12:03:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AllianceInvitationStateRecrutedMessage : Message
{

public const ushort Id = 6392;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public AllianceInvitationStateRecrutedMessage()
{
}

public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
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