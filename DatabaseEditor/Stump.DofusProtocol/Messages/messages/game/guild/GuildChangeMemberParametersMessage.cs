



















// Generated on 04/20/2016 12:03:56
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildChangeMemberParametersMessage : Message
{

public const ushort Id = 5549;
public override ushort MessageId
{
    get { return Id; }
}

public ulong memberId;
        public ushort rank;
        public sbyte experienceGivenPercent;
        public uint rights;
        

public GuildChangeMemberParametersMessage()
{
}

public GuildChangeMemberParametersMessage(ulong memberId, ushort rank, sbyte experienceGivenPercent, uint rights)
        {
            this.memberId = memberId;
            this.rank = rank;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(memberId);
            writer.WriteVarUhShort(rank);
            writer.WriteSByte(experienceGivenPercent);
            writer.WriteVarUhInt(rights);
            

}

public override void Deserialize(ICustomDataInput reader)
{

memberId = reader.ReadVarUhLong();
            if (memberId < 0 || memberId > 9.007199254740992E15)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0 || memberId > 9.007199254740992E15");
            rank = reader.ReadVarUhShort();
            if (rank < 0)
                throw new Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0");
            experienceGivenPercent = reader.ReadSByte();
            if (experienceGivenPercent < 0 || experienceGivenPercent > 100)
                throw new Exception("Forbidden value on experienceGivenPercent = " + experienceGivenPercent + ", it doesn't respect the following condition : experienceGivenPercent < 0 || experienceGivenPercent > 100");
            rights = reader.ReadVarUhInt();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}