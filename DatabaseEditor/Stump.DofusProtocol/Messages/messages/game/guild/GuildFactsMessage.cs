



















// Generated on 04/20/2016 12:03:57
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildFactsMessage : Message
{

public const ushort Id = 6415;
public override ushort MessageId
{
    get { return Id; }
}

public Types.GuildFactSheetInformations infos;
        public int creationDate;
        public ushort nbTaxCollectors;
        public bool enabled;
        public IEnumerable<CharacterMinimalInformations> members;
        

public GuildFactsMessage()
{
}

public GuildFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, ushort nbTaxCollectors, bool enabled, IEnumerable<CharacterMinimalInformations> members)
        {
            this.infos = infos;
            this.creationDate = creationDate;
            this.nbTaxCollectors = nbTaxCollectors;
            this.enabled = enabled;
            this.members = members;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteVarUhShort(nbTaxCollectors);
            writer.WriteBoolean(enabled);
            writer.WriteUShort((ushort)members.Count());
            foreach (var entry in members)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

infos = ProtocolTypeManager.GetInstance<Types.GuildFactSheetInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            creationDate = reader.ReadInt();
            if (creationDate < 0)
                throw new Exception("Forbidden value on creationDate = " + creationDate + ", it doesn't respect the following condition : creationDate < 0");
            nbTaxCollectors = reader.ReadVarUhShort();
            if (nbTaxCollectors < 0)
                throw new Exception("Forbidden value on nbTaxCollectors = " + nbTaxCollectors + ", it doesn't respect the following condition : nbTaxCollectors < 0");
            enabled = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            members = new CharacterMinimalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as CharacterMinimalInformations[])[i].Deserialize(reader);
            }
            

}


}


}