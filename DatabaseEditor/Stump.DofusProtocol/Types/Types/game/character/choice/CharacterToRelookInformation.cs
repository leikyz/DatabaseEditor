



















// Generated on 04/20/2016 12:44:06
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterToRelookInformation : AbstractCharacterToRefurbishInformation
{

public const short Id = 399;
public override short TypeId
{
    get { return Id; }
}



public CharacterToRelookInformation()
{
}

public CharacterToRelookInformation(ulong id, IEnumerable<int> colors, uint cosmeticId)
         : base(id, colors, cosmeticId)
        {
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            

}


}


}