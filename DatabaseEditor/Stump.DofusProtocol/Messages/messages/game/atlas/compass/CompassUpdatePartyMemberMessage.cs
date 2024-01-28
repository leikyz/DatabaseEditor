



















// Generated on 04/20/2016 12:03:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
{

public const ushort Id = 5589;
public override ushort MessageId
{
    get { return Id; }
}

public ulong memberId;
        public bool active;
        

public CompassUpdatePartyMemberMessage()
{
}

public CompassUpdatePartyMemberMessage(sbyte type, Types.MapCoordinates coords, ulong memberId, bool active)
         : base(type, coords)
        {
            this.memberId = memberId;
            this.active = active;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(memberId);
            writer.WriteBoolean(active);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            memberId = reader.ReadVarUhLong();
            if (memberId < 0 || memberId > 9.007199254740992E15)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0 || memberId > 9.007199254740992E15");
            active = reader.ReadBoolean();
            

}


}


}