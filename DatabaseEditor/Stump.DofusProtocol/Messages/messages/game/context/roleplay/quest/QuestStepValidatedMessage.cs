



















// Generated on 04/20/2016 12:03:51
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class QuestStepValidatedMessage : Message
{

public const ushort Id = 6099;
public override ushort MessageId
{
    get { return Id; }
}

public ushort questId;
        public ushort stepId;
        

public QuestStepValidatedMessage()
{
}

public QuestStepValidatedMessage(ushort questId, ushort stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(questId);
            writer.WriteVarUhShort(stepId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

questId = reader.ReadVarUhShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            stepId = reader.ReadVarUhShort();
            if (stepId < 0)
                throw new Exception("Forbidden value on stepId = " + stepId + ", it doesn't respect the following condition : stepId < 0");
            

}


}


}