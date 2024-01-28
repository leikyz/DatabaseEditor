



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareRewardConsumeValidationMessage : Message
{

public const ushort Id = 6675;
public override ushort MessageId
{
    get { return Id; }
}

public double dareId;
        public sbyte type;
        

public DareRewardConsumeValidationMessage()
{
}

public DareRewardConsumeValidationMessage(double dareId, sbyte type)
        {
            this.dareId = dareId;
            this.type = type;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(dareId);
            writer.WriteSByte(type);
            

}

public override void Deserialize(ICustomDataInput reader)
{

dareId = reader.ReadDouble();
            if (dareId < 0 || dareId > 9.007199254740992E15)
                throw new Exception("Forbidden value on dareId = " + dareId + ", it doesn't respect the following condition : dareId < 0 || dareId > 9.007199254740992E15");
            type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}