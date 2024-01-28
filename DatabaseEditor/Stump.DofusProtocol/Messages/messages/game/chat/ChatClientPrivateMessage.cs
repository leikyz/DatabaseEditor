



















// Generated on 04/20/2016 12:03:18
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatClientPrivateMessage : ChatAbstractClientMessage
{

public const ushort Id = 851;
public override ushort MessageId
{
    get { return Id; }
}

public string receiver;
        

public ChatClientPrivateMessage()
{
}

public ChatClientPrivateMessage(string content, string receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUTF(receiver);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            receiver = reader.ReadUTF();
            

}


}


}