



















// Generated on 04/20/2016 12:03:27
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChallengeResultMessage : Message
{

public const ushort Id = 6019;
public override ushort MessageId
{
    get { return Id; }
}

public ushort challengeId;
        public bool success;
        

public ChallengeResultMessage()
{
}

public ChallengeResultMessage(ushort challengeId, bool success)
        {
            this.challengeId = challengeId;
            this.success = success;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(challengeId);
            writer.WriteBoolean(success);
            

}

public override void Deserialize(ICustomDataInput reader)
{

challengeId = reader.ReadVarUhShort();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            success = reader.ReadBoolean();
            

}


}


}