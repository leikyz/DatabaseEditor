



















// Generated on 04/20/2016 12:03:45
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
{

public const ushort Id = 5581;
public override ushort MessageId
{
    get { return Id; }
}

public bool success;
        public bool isFollowed;
        public ulong followedId;
        

public PartyFollowStatusUpdateMessage()
{
}

public PartyFollowStatusUpdateMessage(uint partyId, bool success, bool isFollowed, ulong followedId)
         : base(partyId)
        {
            this.success = success;
            this.isFollowed = isFollowed;
            this.followedId = followedId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isFollowed);
            writer.WriteByte(flag1);
            writer.WriteVarUhLong(followedId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            isFollowed = BooleanByteWrapper.GetFlag(flag1, 1);
            followedId = reader.ReadVarUhLong();
            if (followedId < 0 || followedId > 9.007199254740992E15)
                throw new Exception("Forbidden value on followedId = " + followedId + ", it doesn't respect the following condition : followedId < 0 || followedId > 9.007199254740992E15");
            

}


}


}