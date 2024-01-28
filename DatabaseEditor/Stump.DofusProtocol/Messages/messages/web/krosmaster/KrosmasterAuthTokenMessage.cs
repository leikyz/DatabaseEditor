



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class KrosmasterAuthTokenMessage : Message
{

public const ushort Id = 6351;
public override ushort MessageId
{
    get { return Id; }
}

public string token;
        

public KrosmasterAuthTokenMessage()
{
}

public KrosmasterAuthTokenMessage(string token)
        {
            this.token = token;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(token);
            

}

public override void Deserialize(ICustomDataInput reader)
{

token = reader.ReadUTF();
            

}


}


}