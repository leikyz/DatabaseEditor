



















// Generated on 04/20/2016 12:03:46
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyJoinMessage : AbstractPartyMessage
{

public const ushort Id = 5576;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public ulong partyLeaderId;
        public sbyte maxParticipants;
        public IEnumerable<Types.PartyMemberInformations> members;
        public IEnumerable<PartyGuestInformations> guests;
        public bool restricted;
        public string partyName;
        

public PartyJoinMessage()
{
}

public PartyJoinMessage(uint partyId, sbyte partyType, ulong partyLeaderId, sbyte maxParticipants, IEnumerable<Types.PartyMemberInformations> members, IEnumerable<PartyGuestInformations> guests, bool restricted, string partyName)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyLeaderId = partyLeaderId;
            this.maxParticipants = maxParticipants;
            this.members = members;
            this.guests = guests;
            this.restricted = restricted;
            this.partyName = partyName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteVarUhLong(partyLeaderId);
            writer.WriteSByte(maxParticipants);
            writer.WriteUShort((ushort)members.Count());
            foreach (var entry in members)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)guests.Count());
            foreach (var entry in guests)
            {
                entry.Serialize(writer);
            }
            writer.WriteBoolean(restricted);
            writer.WriteUTF(partyName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSByte();
            if (partyType < 0)
                throw new Exception("Forbidden value on partyType = " + partyType + ", it doesn't respect the following condition : partyType < 0");
            partyLeaderId = reader.ReadVarUhLong();
            if (partyLeaderId < 0 || partyLeaderId > 9.007199254740992E15)
                throw new Exception("Forbidden value on partyLeaderId = " + partyLeaderId + ", it doesn't respect the following condition : partyLeaderId < 0 || partyLeaderId > 9.007199254740992E15");
            maxParticipants = reader.ReadSByte();
            if (maxParticipants < 0)
                throw new Exception("Forbidden value on maxParticipants = " + maxParticipants + ", it doesn't respect the following condition : maxParticipants < 0");
            var limit = reader.ReadUShort();
            members = new Types.PartyMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as Types.PartyMemberInformations[])[i] = ProtocolTypeManager.GetInstance<Types.PartyMemberInformations>(reader.ReadShort());
                 (members as Types.PartyMemberInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            guests = new PartyGuestInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guests as PartyGuestInformations[])[i].Deserialize(reader);
            }
            restricted = reader.ReadBoolean();
            partyName = reader.ReadUTF();
            

}


}


}