



















// Generated on 04/20/2016 12:03:50
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class QuestStartRequestMessage : Message
{

public const ushort Id = 5643;
public override ushort MessageId
{
    get { return Id; }
}

public ushort questId;
        

public QuestStartRequestMessage()
{
}

public QuestStartRequestMessage(ushort questId)
        {
            this.questId = questId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(questId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

questId = reader.ReadVarUhShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            

}


}


}