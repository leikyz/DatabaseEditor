



















// Generated on 04/20/2016 12:04:18
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IdolsPresetDeleteResultMessage : Message
{

public const ushort Id = 6605;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        

public IdolsPresetDeleteResultMessage()
{
}

public IdolsPresetDeleteResultMessage(sbyte presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            

}

public override void Deserialize(ICustomDataInput reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            

}


}


}