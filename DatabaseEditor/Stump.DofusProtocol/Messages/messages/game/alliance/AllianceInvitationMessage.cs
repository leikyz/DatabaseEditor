



















// Generated on 04/20/2016 12:03:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AllianceInvitationMessage : Message
{

public const ushort Id = 6395;
public override ushort MessageId
{
    get { return Id; }
}

public ulong targetId;
        

public AllianceInvitationMessage()
{
}

public AllianceInvitationMessage(ulong targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(targetId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

targetId = reader.ReadVarUhLong();
            if (targetId < 0 || targetId > 9.007199254740992E15)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0 || targetId > 9.007199254740992E15");
            

}


}


}