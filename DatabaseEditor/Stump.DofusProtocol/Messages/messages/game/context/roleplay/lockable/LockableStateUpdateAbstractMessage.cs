



















// Generated on 04/20/2016 12:03:41
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class LockableStateUpdateAbstractMessage : Message
{

public const ushort Id = 5671;
public override ushort MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(locked);
            

}

public override void Deserialize(ICustomDataInput reader)
{

locked = reader.ReadBoolean();
            

}


}


}