



















// Generated on 04/20/2016 12:03:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class BasicWhoIsNoMatchMessage : Message
{

public const ushort Id = 179;
public override ushort MessageId
{
    get { return Id; }
}

public string search;
        

public BasicWhoIsNoMatchMessage()
{
}

public BasicWhoIsNoMatchMessage(string search)
        {
            this.search = search;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(search);
            

}

public override void Deserialize(ICustomDataInput reader)
{

search = reader.ReadUTF();
            

}


}


}