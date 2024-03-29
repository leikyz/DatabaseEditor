



















// Generated on 04/20/2016 12:04:18
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IdolsPresetSaveMessage : Message
{

public const ushort Id = 6603;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte symbolId;
        

public IdolsPresetSaveMessage()
{
}

public IdolsPresetSaveMessage(sbyte presetId, sbyte symbolId)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            symbolId = reader.ReadSByte();
            if (symbolId < 0)
                throw new Exception("Forbidden value on symbolId = " + symbolId + ", it doesn't respect the following condition : symbolId < 0");
            

}


}


}