



















// Generated on 04/20/2016 12:03:56
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SpouseStatusMessage : Message
{

public const ushort Id = 6265;
public override ushort MessageId
{
    get { return Id; }
}

public bool hasSpouse;
        

public SpouseStatusMessage()
{
}

public SpouseStatusMessage(bool hasSpouse)
        {
            this.hasSpouse = hasSpouse;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(hasSpouse);
            

}

public override void Deserialize(ICustomDataInput reader)
{

hasSpouse = reader.ReadBoolean();
            

}


}


}