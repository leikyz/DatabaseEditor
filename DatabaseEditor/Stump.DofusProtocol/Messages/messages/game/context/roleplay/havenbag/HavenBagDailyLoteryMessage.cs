



















// Generated on 04/20/2016 12:03:36
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class HavenBagDailyLoteryMessage : Message
{

public const ushort Id = 6644;
public override ushort MessageId
{
    get { return Id; }
}

public string tokenId;
        

public HavenBagDailyLoteryMessage()
{
}

public HavenBagDailyLoteryMessage(string tokenId)
        {
            this.tokenId = tokenId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(tokenId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

tokenId = reader.ReadUTF();
            

}


}


}