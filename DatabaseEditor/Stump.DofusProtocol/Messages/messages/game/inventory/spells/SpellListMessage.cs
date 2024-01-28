



















// Generated on 04/20/2016 12:04:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SpellListMessage : Message
{

public const ushort Id = 1200;
public override ushort MessageId
{
    get { return Id; }
}

public bool spellPrevisualization;
        public IEnumerable<SpellItem> spells;
        

public SpellListMessage()
{
}

public SpellListMessage(bool spellPrevisualization, IEnumerable<SpellItem> spells)
        {
            this.spellPrevisualization = spellPrevisualization;
            this.spells = spells;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(spellPrevisualization);
            writer.WriteUShort((ushort)spells.Count());
            foreach (var entry in spells)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

spellPrevisualization = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            spells = new SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (spells as SpellItem[])[i].Deserialize(reader);
            }
            

}


}


}