



















// Generated on 04/20/2016 12:04:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class InventoryPresetUseResultMessage : Message
{

public const ushort Id = 6163;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        public IEnumerable<byte> unlinkedPosition;
        

public InventoryPresetUseResultMessage()
{
}

public InventoryPresetUseResultMessage(sbyte presetId, sbyte code, IEnumerable<byte> unlinkedPosition)
        {
            this.presetId = presetId;
            this.code = code;
            this.unlinkedPosition = unlinkedPosition;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            writer.WriteUShort((ushort)unlinkedPosition.Count());
            foreach (var entry in unlinkedPosition)
            {
                 writer.WriteByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            var limit = reader.ReadUShort();
            unlinkedPosition = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (unlinkedPosition as byte[])[i] = reader.ReadByte();
            }
            

}


}


}