



















// Generated on 04/20/2016 12:04:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class InteractiveUseErrorMessage : Message
{

public const ushort Id = 6384;
public override ushort MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillInstanceUid;
        

public InteractiveUseErrorMessage()
{
}

public InteractiveUseErrorMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(elemId);
            writer.WriteVarUhInt(skillInstanceUid);
            

}

public override void Deserialize(ICustomDataInput reader)
{

elemId = reader.ReadVarUhInt();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillInstanceUid = reader.ReadVarUhInt();
            if (skillInstanceUid < 0)
                throw new Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}