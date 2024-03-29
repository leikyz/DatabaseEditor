



















// Generated on 04/20/2016 12:04:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class InteractiveUseEndedMessage : Message
{

public const ushort Id = 6112;
public override ushort MessageId
{
    get { return Id; }
}

public uint elemId;
        public ushort skillId;
        

public InteractiveUseEndedMessage()
{
}

public InteractiveUseEndedMessage(uint elemId, ushort skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(elemId);
            writer.WriteVarUhShort(skillId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

elemId = reader.ReadVarUhInt();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillId = reader.ReadVarUhShort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}