



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PaddockToSellFilterMessage : Message
{

public const ushort Id = 6161;
public override ushort MessageId
{
    get { return Id; }
}

public int areaId;
        public sbyte atLeastNbMount;
        public sbyte atLeastNbMachine;
        public uint maxPrice;
        

public PaddockToSellFilterMessage()
{
}

public PaddockToSellFilterMessage(int areaId, sbyte atLeastNbMount, sbyte atLeastNbMachine, uint maxPrice)
        {
            this.areaId = areaId;
            this.atLeastNbMount = atLeastNbMount;
            this.atLeastNbMachine = atLeastNbMachine;
            this.maxPrice = maxPrice;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(areaId);
            writer.WriteSByte(atLeastNbMount);
            writer.WriteSByte(atLeastNbMachine);
            writer.WriteVarUhInt(maxPrice);
            

}

public override void Deserialize(ICustomDataInput reader)
{

areaId = reader.ReadInt();
            atLeastNbMount = reader.ReadSByte();
            atLeastNbMachine = reader.ReadSByte();
            maxPrice = reader.ReadVarUhInt();
            if (maxPrice < 0)
                throw new Exception("Forbidden value on maxPrice = " + maxPrice + ", it doesn't respect the following condition : maxPrice < 0");
            

}


}


}