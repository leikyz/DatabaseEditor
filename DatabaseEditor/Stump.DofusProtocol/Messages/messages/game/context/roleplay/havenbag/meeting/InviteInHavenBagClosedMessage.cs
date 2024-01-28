



















// Generated on 04/20/2016 12:03:37
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class InviteInHavenBagClosedMessage : Message
{

public const ushort Id = 6645;
public override ushort MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations hostInformations;
        

public InviteInHavenBagClosedMessage()
{
}

public InviteInHavenBagClosedMessage(Types.CharacterMinimalInformations hostInformations)
        {
            this.hostInformations = hostInformations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

hostInformations.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            

}


}


}