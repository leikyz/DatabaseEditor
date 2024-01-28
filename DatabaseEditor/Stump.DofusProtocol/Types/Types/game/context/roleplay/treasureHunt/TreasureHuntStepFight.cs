



















// Generated on 04/20/2016 12:44:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class TreasureHuntStepFight : TreasureHuntStep
{

public const short Id = 462;
public override short TypeId
{
    get { return Id; }
}



public TreasureHuntStepFight()
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