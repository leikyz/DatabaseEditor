



















// Generated on 04/20/2016 12:03:58
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildInvitationStateRecruterMessage : Message
{

public const ushort Id = 5563;
public override ushort MessageId
{
    get { return Id; }
}

public string recrutedName;
        public sbyte invitationState;
        

public GuildInvitationStateRecruterMessage()
{
}

public GuildInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(recrutedName);
            writer.WriteSByte(invitationState);
            

}

public override void Deserialize(ICustomDataInput reader)
{

recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}