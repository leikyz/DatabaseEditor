



















// Generated on 04/20/2016 12:03:54
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class FriendsListMessage : Message
{

public const ushort Id = 4002;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.FriendInformations> friendsList;
        

public FriendsListMessage()
{
}

public FriendsListMessage(IEnumerable<Types.FriendInformations> friendsList)
        {
            this.friendsList = friendsList;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)friendsList.Count());
            foreach (var entry in friendsList)
            {
                 writer.WriteUShort((ushort)entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            friendsList = new Types.FriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (friendsList as Types.FriendInformations[])[i] = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadShort());
                 (friendsList as Types.FriendInformations[])[i].Deserialize(reader);
            }
            

}


}


}