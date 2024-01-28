



















// Generated on 04/20/2016 12:03:54
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class FriendAddedMessage : Message
{

public const ushort Id = 5599;
public override ushort MessageId
{
    get { return Id; }
}

public Types.FriendInformations friendAdded;
        

public FriendAddedMessage()
{
}

public FriendAddedMessage(Types.FriendInformations friendAdded)
        {
            this.friendAdded = friendAdded;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(friendAdded.TypeId);
            friendAdded.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

friendAdded = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadShort());
            friendAdded.Deserialize(reader);
            

}


}


}