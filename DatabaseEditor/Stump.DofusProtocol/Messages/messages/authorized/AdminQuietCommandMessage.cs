



















// Generated on 04/20/2016 12:03:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AdminQuietCommandMessage : AdminCommandMessage
{

public const ushort Id = 5662;
public override ushort MessageId
{
    get { return Id; }
}



public AdminQuietCommandMessage()
{
}

public AdminQuietCommandMessage(string content)
         : base(content)
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