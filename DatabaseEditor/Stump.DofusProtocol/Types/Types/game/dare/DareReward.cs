



















// Generated on 04/20/2016 12:44:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class DareReward
{

public const short Id = 505;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        public ushort monsterId;
        public uint kamas;
        public double dareId;
        

public DareReward()
{
}

public DareReward(sbyte type, ushort monsterId, uint kamas, double dareId)
        {
            this.type = type;
            this.monsterId = monsterId;
            this.kamas = kamas;
            this.dareId = dareId;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(type);
            writer.WriteVarUhShort(monsterId);
            writer.WriteUInt(kamas);
            writer.WriteDouble(dareId);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            monsterId = reader.ReadVarUhShort();
            if (monsterId < 0)
                throw new Exception("Forbidden value on monsterId = " + monsterId + ", it doesn't respect the following condition : monsterId < 0");
            kamas = reader.ReadUInt();
            if (kamas < 0 || kamas > 4.294967295E9)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0 || kamas > 4.294967295E9");
            dareId = reader.ReadDouble();
            if (dareId < 0 || dareId > 9.007199254740992E15)
                throw new Exception("Forbidden value on dareId = " + dareId + ", it doesn't respect the following condition : dareId < 0 || dareId > 9.007199254740992E15");
            

}


}


}