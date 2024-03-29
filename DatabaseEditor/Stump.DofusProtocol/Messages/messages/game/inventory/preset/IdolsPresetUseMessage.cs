



















// Generated on 04/20/2016 12:04:18
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IdolsPresetUseMessage : Message
{

public const ushort Id = 6615;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public bool party;
        

public IdolsPresetUseMessage()
{
}

public IdolsPresetUseMessage(sbyte presetId, bool party)
        {
            this.presetId = presetId;
            this.party = party;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(presetId);
            writer.WriteBoolean(party);
            

}

public override void Deserialize(ICustomDataInput reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            party = reader.ReadBoolean();
            

}


}


}