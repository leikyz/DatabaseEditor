



















// Generated on 04/20/2016 12:03:45
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyInvitationDetailsMessage : AbstractPartyMessage
{

public const ushort Id = 6263;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public string partyName;
        public ulong fromId;
        public string fromName;
        public ulong leaderId;
        public IEnumerable<PartyInvitationMemberInformations> members;
        public IEnumerable<PartyGuestInformations> guests;
        

public PartyInvitationDetailsMessage()
{
}

public PartyInvitationDetailsMessage(uint partyId, sbyte partyType, string partyName, ulong fromId, string fromName, ulong leaderId, IEnumerable<PartyInvitationMemberInformations> members, IEnumerable<PartyGuestInformations> guests)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.fromId = fromId;
            this.fromName = fromName;
            this.leaderId = leaderId;
            this.members = members;
            this.guests = guests;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteVarUhLong(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVarUhLong(leaderId);
            writer.WriteUShort((ushort)members.Count());
            foreach (var entry in members)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)guests.Count());
            foreach (var entry in guests)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSByte();
            if (partyType < 0)
                throw new Exception("Forbidden value on partyType = " + partyType + ", it doesn't respect the following condition : partyType < 0");
            partyName = reader.ReadUTF();
            fromId = reader.ReadVarUhLong();
            if (fromId < 0 || fromId > 9.007199254740992E15)
                throw new Exception("Forbidden value on fromId = " + fromId + ", it doesn't respect the following condition : fromId < 0 || fromId > 9.007199254740992E15");
            fromName = reader.ReadUTF();
            leaderId = reader.ReadVarUhLong();
            if (leaderId < 0 || leaderId > 9.007199254740992E15)
                throw new Exception("Forbidden value on leaderId = " + leaderId + ", it doesn't respect the following condition : leaderId < 0 || leaderId > 9.007199254740992E15");
            var limit = reader.ReadUShort();
            members = new PartyInvitationMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as PartyInvitationMemberInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            guests = new PartyGuestInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guests as PartyGuestInformations[])[i].Deserialize(reader);
            }
            

}


}


}