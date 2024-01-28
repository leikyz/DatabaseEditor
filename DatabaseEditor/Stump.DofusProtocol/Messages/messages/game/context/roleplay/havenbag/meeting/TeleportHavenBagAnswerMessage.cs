



















// Generated on 04/20/2016 12:03:37
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TeleportHavenBagAnswerMessage : Message
{

public const ushort Id = 6646;
public override ushort MessageId
{
    get { return Id; }
}

public bool accept;
        

public TeleportHavenBagAnswerMessage()
{
}

public TeleportHavenBagAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(accept);
            

}

public override void Deserialize(ICustomDataInput reader)
{

accept = reader.ReadBoolean();
            

}


}


}