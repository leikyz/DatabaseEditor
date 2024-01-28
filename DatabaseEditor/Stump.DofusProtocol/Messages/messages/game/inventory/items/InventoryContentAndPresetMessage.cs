



















// Generated on 04/20/2016 12:04:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class InventoryContentAndPresetMessage : InventoryContentMessage
{

public const ushort Id = 6162;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Preset> presets;
        public IEnumerable<IdolsPreset> idolsPresets;
        

public InventoryContentAndPresetMessage()
{
}

public InventoryContentAndPresetMessage(IEnumerable<ObjectItem> objects, uint kamas, IEnumerable<Preset> presets, IEnumerable<IdolsPreset> idolsPresets)
         : base(objects, kamas)
        {
            this.presets = presets;
            this.idolsPresets = idolsPresets;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)presets.Count());
            foreach (var entry in presets)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)idolsPresets.Count());
            foreach (var entry in idolsPresets)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            presets = new Preset[limit];
            for (int i = 0; i < limit; i++)
            {
                 (presets as Preset[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            idolsPresets = new IdolsPreset[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idolsPresets as IdolsPreset[])[i].Deserialize(reader);
            }
            

}


}


}