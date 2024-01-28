



















// Generated on 04/20/2016 12:03:24
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightHumanReadyStateMessage : Message
{

public const ushort Id = 740;
public override ushort MessageId
{
    get { return Id; }
}

public ulong characterId;
        public bool isReady;
        

public GameFightHumanReadyStateMessage()
{
}

public GameFightHumanReadyStateMessage(ulong characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(characterId);
            writer.WriteBoolean(isReady);
            

}

public override void Deserialize(ICustomDataInput reader)
{

characterId = reader.ReadVarUhLong();
            if (characterId < 0 || characterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0 || characterId > 9.007199254740992E15");
            isReady = reader.ReadBoolean();
            

}


}


}