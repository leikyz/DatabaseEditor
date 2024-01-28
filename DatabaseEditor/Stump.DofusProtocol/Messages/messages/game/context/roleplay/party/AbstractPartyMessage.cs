



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AbstractPartyMessage : Message
{

public const ushort Id = 6274;
public override ushort MessageId
{
    get { return Id; }
}

public uint partyId;
        

public AbstractPartyMessage()
{
}

public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(partyId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

partyId = reader.ReadVarUhInt();
            if (partyId < 0)
                throw new Exception("Forbidden value on partyId = " + partyId + ", it doesn't respect the following condition : partyId < 0");
            

}


}


}