



















// Generated on 04/20/2016 12:03:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AcquaintanceSearchMessage : Message
{

public const ushort Id = 6144;
public override ushort MessageId
{
    get { return Id; }
}

public string nickname;
        

public AcquaintanceSearchMessage()
{
}

public AcquaintanceSearchMessage(string nickname)
        {
            this.nickname = nickname;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(nickname);
            

}

public override void Deserialize(ICustomDataInput reader)
{

nickname = reader.ReadUTF();
            

}


}


}