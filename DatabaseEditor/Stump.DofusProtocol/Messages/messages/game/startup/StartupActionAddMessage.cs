



















// Generated on 04/20/2016 12:04:22
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StartupActionAddMessage : Message
{

public const ushort Id = 6538;
public override ushort MessageId
{
    get { return Id; }
}

public StartupActionAddObject newAction;
        

public StartupActionAddMessage()
{
}

public StartupActionAddMessage(StartupActionAddObject newAction)
        {
            this.newAction = newAction;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

            newAction.Serialize(writer);


        }

public override void Deserialize(ICustomDataInput reader)
{

newAction.Deserialize(reader);


        }


}


}