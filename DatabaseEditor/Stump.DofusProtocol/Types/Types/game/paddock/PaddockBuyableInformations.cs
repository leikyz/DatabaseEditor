



















// Generated on 04/20/2016 12:44:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class PaddockBuyableInformations : PaddockInformations
{

public const short Id = 130;
public override short TypeId
{
    get { return Id; }
}

public uint price;
        public bool locked;
        

public PaddockBuyableInformations()
{
}

public PaddockBuyableInformations(ushort maxOutdoorMount, ushort maxItems, uint price, bool locked)
         : base(maxOutdoorMount, maxItems)
        {
            this.price = price;
            this.locked = locked;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhInt(price);
            writer.WriteBoolean(locked);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            price = reader.ReadVarUhInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            locked = reader.ReadBoolean();
            

}


}


}