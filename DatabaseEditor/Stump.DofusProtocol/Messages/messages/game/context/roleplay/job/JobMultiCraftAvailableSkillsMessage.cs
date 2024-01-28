



















// Generated on 04/20/2016 12:03:41
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
{

public const ushort Id = 5747;
public override ushort MessageId
{
    get { return Id; }
}

public ulong playerId;
        public IEnumerable<ushort> skills;
        

public JobMultiCraftAvailableSkillsMessage()
{
}

public JobMultiCraftAvailableSkillsMessage(bool enabled, ulong playerId, IEnumerable<ushort> skills)
         : base(enabled)
        {
            this.playerId = playerId;
            this.skills = skills;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhLong(playerId);
            writer.WriteUShort((ushort)skills.Count());
            foreach (var entry in skills)
            {
                 writer.WriteVarUhShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            var limit = reader.ReadUShort();
            skills = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (skills as ushort[])[i] = reader.ReadVarUhShort();
            }
            

}


}


}