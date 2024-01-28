



















// Generated on 04/20/2016 12:03:38
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
{

public const ushort Id = 5885;
public override ushort MessageId
{
    get { return Id; }
}



public HouseLockFromInsideRequestMessage()
{
}

public HouseLockFromInsideRequestMessage(string code)
         : base(code)
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