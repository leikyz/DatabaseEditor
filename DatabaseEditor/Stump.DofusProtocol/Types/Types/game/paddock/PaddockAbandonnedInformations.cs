



















// Generated on 04/20/2016 12:44:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class PaddockAbandonnedInformations : PaddockBuyableInformations
{

public const short Id = 133;
public override short TypeId
{
    get { return Id; }
}

public int guildId;
        

public PaddockAbandonnedInformations()
{
}

public PaddockAbandonnedInformations(ushort maxOutdoorMount, ushort maxItems, uint price, bool locked, int guildId)
         : base(maxOutdoorMount, maxItems, price, locked)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(guildId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            guildId = reader.ReadInt();
            

}


}


}