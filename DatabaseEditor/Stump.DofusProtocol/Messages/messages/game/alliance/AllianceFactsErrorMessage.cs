



















// Generated on 04/20/2016 12:03:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AllianceFactsErrorMessage : Message
{

public const ushort Id = 6423;
public override ushort MessageId
{
    get { return Id; }
}

public uint allianceId;
        

public AllianceFactsErrorMessage()
{
}

public AllianceFactsErrorMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(allianceId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

allianceId = reader.ReadVarUhInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}