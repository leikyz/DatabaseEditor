



















// Generated on 04/20/2016 12:04:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IdolPartyLostMessage : Message
{

public const ushort Id = 6580;
public override ushort MessageId
{
    get { return Id; }
}

public ushort idolId;
        

public IdolPartyLostMessage()
{
}

public IdolPartyLostMessage(ushort idolId)
        {
            this.idolId = idolId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(idolId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

idolId = reader.ReadVarUhShort();
            if (idolId < 0)
                throw new Exception("Forbidden value on idolId = " + idolId + ", it doesn't respect the following condition : idolId < 0");
            

}


}


}