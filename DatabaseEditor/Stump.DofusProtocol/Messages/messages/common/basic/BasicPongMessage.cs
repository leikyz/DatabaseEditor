



















// Generated on 04/20/2016 12:03:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class BasicPongMessage : Message
{

public const ushort Id = 183;
public override ushort MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPongMessage()
{
}

public BasicPongMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(quiet);
            

}

public override void Deserialize(ICustomDataInput reader)
{

quiet = reader.ReadBoolean();
            

}


}


}