



















// Generated on 04/20/2016 12:04:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PrismInfoJoinLeaveRequestMessage : Message
{

public const ushort Id = 5844;
public override ushort MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismInfoJoinLeaveRequestMessage()
{
}

public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(join);
            

}

public override void Deserialize(ICustomDataInput reader)
{

join = reader.ReadBoolean();
            

}


}


}