



















// Generated on 04/20/2016 12:03:27
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SlaveSwitchContextMessage : Message
{

public const ushort Id = 6214;
public override ushort MessageId
{
    get { return Id; }
}

public double masterId;
        public double slaveId;
        public IEnumerable<SpellItem> slaveSpells;
        public Types.CharacterCharacteristicsInformations slaveStats;
        public IEnumerable<Types.Shortcut> shortcuts;
        

public SlaveSwitchContextMessage()
{
}

public SlaveSwitchContextMessage(double masterId, double slaveId, IEnumerable<SpellItem> slaveSpells, Types.CharacterCharacteristicsInformations slaveStats, IEnumerable<Types.Shortcut> shortcuts)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
            this.slaveSpells = slaveSpells;
            this.slaveStats = slaveStats;
            this.shortcuts = shortcuts;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(masterId);
            writer.WriteDouble(slaveId);
            writer.WriteUShort((ushort)slaveSpells.Count());
            foreach (var entry in slaveSpells)
            {
                entry.Serialize(writer);
            }
            slaveStats.Serialize(writer);
            writer.WriteUShort((ushort)shortcuts.Count());
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

masterId = reader.ReadDouble();
            if (masterId < -9.007199254740992E15 || masterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on masterId = " + masterId + ", it doesn't respect the following condition : masterId < -9.007199254740992E15 || masterId > 9.007199254740992E15");
            slaveId = reader.ReadDouble();
            if (slaveId < -9.007199254740992E15 || slaveId > 9.007199254740992E15)
                throw new Exception("Forbidden value on slaveId = " + slaveId + ", it doesn't respect the following condition : slaveId < -9.007199254740992E15 || slaveId > 9.007199254740992E15");
            var limit = reader.ReadUShort();
            slaveSpells = new SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (slaveSpells as SpellItem[])[i].Deserialize(reader);
            }
            slaveStats = new Types.CharacterCharacteristicsInformations();
            slaveStats.Deserialize(reader);
            limit = reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 (shortcuts as Types.Shortcut[])[i] = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
                 (shortcuts as Types.Shortcut[])[i].Deserialize(reader);
            }
            

}


}


}