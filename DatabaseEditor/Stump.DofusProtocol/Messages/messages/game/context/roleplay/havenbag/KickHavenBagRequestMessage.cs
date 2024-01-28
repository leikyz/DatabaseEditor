



















// Generated on 04/20/2016 12:03:37
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class KickHavenBagRequestMessage : Message
{

public const ushort Id = 6652;
public override ushort MessageId
{
    get { return Id; }
}

public ulong guestId;
        

public KickHavenBagRequestMessage()
{
}

public KickHavenBagRequestMessage(ulong guestId)
        {
            this.guestId = guestId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(guestId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

guestId = reader.ReadVarUhLong();
            if (guestId < 0 || guestId > 9.007199254740992E15)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0 || guestId > 9.007199254740992E15");
            

}


}


}