



















// Generated on 04/20/2016 12:03:54
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class FriendDeleteRequestMessage : Message
{

public const ushort Id = 5603;
public override ushort MessageId
{
    get { return Id; }
}

public int accountId;
        

public FriendDeleteRequestMessage()
{
}

public FriendDeleteRequestMessage(int accountId)
        {
            this.accountId = accountId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(accountId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}