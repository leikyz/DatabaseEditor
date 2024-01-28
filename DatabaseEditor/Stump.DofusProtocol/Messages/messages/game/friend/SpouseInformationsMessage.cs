



















// Generated on 04/20/2016 12:03:56
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SpouseInformationsMessage : Message
{

public const ushort Id = 6356;
public override ushort MessageId
{
    get { return Id; }
}

public Types.FriendSpouseInformations spouse;
        

public SpouseInformationsMessage()
{
}

public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

spouse = ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadShort());
            spouse.Deserialize(reader);
            

}


}


}