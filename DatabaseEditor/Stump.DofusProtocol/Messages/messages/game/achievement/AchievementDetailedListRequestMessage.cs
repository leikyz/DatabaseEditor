



















// Generated on 04/20/2016 12:03:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AchievementDetailedListRequestMessage : Message
{

public const ushort Id = 6357;
public override ushort MessageId
{
    get { return Id; }
}

public ushort categoryId;
        

public AchievementDetailedListRequestMessage()
{
}

public AchievementDetailedListRequestMessage(ushort categoryId)
        {
            this.categoryId = categoryId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(categoryId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

categoryId = reader.ReadVarUhShort();
            if (categoryId < 0)
                throw new Exception("Forbidden value on categoryId = " + categoryId + ", it doesn't respect the following condition : categoryId < 0");
            

}


}


}