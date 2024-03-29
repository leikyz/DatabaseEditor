



















// Generated on 04/20/2016 12:03:51
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StatsUpgradeResultMessage : Message
{

public const ushort Id = 5609;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte result;
        public ushort nbCharacBoost;
        

public StatsUpgradeResultMessage()
{
}

public StatsUpgradeResultMessage(sbyte result, ushort nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(result);
            writer.WriteVarUhShort(nbCharacBoost);
            

}

public override void Deserialize(ICustomDataInput reader)
{

result = reader.ReadSByte();
            nbCharacBoost = reader.ReadVarUhShort();
            if (nbCharacBoost < 0)
                throw new Exception("Forbidden value on nbCharacBoost = " + nbCharacBoost + ", it doesn't respect the following condition : nbCharacBoost < 0");
            

}


}


}