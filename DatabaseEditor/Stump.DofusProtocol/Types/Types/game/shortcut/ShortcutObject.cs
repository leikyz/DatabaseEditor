



















// Generated on 04/20/2016 12:44:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class ShortcutObject : Shortcut
{

public const short Id = 367;
public override short TypeId
{
    get { return Id; }
}



public ShortcutObject()
{
}

public ShortcutObject(sbyte slot)
         : base(slot)
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