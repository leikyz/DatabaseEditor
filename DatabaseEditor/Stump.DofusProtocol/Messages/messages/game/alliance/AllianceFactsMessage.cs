



















// Generated on 04/20/2016 12:03:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AllianceFactsMessage : Message
{

public const ushort Id = 6414;
public override ushort MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations infos;
        public IEnumerable<GuildInAllianceInformations> guilds;
        public IEnumerable<ushort> controlledSubareaIds;
        public ulong leaderCharacterId;
        public string leaderCharacterName;
        

public AllianceFactsMessage()
{
}

public AllianceFactsMessage(Types.AllianceFactSheetInformations infos, IEnumerable<GuildInAllianceInformations> guilds, IEnumerable<ushort> controlledSubareaIds, ulong leaderCharacterId, string leaderCharacterName)
        {
            this.infos = infos;
            this.guilds = guilds;
            this.controlledSubareaIds = controlledSubareaIds;
            this.leaderCharacterId = leaderCharacterId;
            this.leaderCharacterName = leaderCharacterName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteUShort((ushort)guilds.Count());
            foreach (var entry in guilds)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)controlledSubareaIds.Count());
            foreach (var entry in controlledSubareaIds)
            {
                 writer.WriteVarUhShort(entry);
            }
            writer.WriteVarUhLong(leaderCharacterId);
            writer.WriteUTF(leaderCharacterName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

infos = ProtocolTypeManager.GetInstance<Types.AllianceFactSheetInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            var limit = reader.ReadUShort();
            guilds = new GuildInAllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guilds as GuildInAllianceInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            controlledSubareaIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (controlledSubareaIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            leaderCharacterId = reader.ReadVarUhLong();
            if (leaderCharacterId < 0 || leaderCharacterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on leaderCharacterId = " + leaderCharacterId + ", it doesn't respect the following condition : leaderCharacterId < 0 || leaderCharacterId > 9.007199254740992E15");
            leaderCharacterName = reader.ReadUTF();
            

}


}


}