



















// Generated on 04/20/2016 12:03:46
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyInvitationDungeonMessage : PartyInvitationMessage
{

public const ushort Id = 6244;
public override ushort MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        

public PartyInvitationDungeonMessage()
{
}

public PartyInvitationDungeonMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, ulong fromId, string fromName, ulong toId, ushort dungeonId)
         : base(partyId, partyType, partyName, maxParticipants, fromId, fromName, toId)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(dungeonId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}