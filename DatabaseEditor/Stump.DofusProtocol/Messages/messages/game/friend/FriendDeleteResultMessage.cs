



















// Generated on 04/20/2016 12:03:54
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class FriendDeleteResultMessage : Message
{

public const ushort Id = 5601;
public override ushort MessageId
{
    get { return Id; }
}

public bool success;
        public string name;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, string name)
        {
            this.success = success;
            this.name = name;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(success);
            writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataInput reader)
{

success = reader.ReadBoolean();
            name = reader.ReadUTF();
            

}


}


}