



















// Generated on 04/20/2016 12:03:48
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartyNameSetRequestMessage : AbstractPartyMessage
{

public const ushort Id = 6503;
public override ushort MessageId
{
    get { return Id; }
}

public string partyName;
        

public PartyNameSetRequestMessage()
{
}

public PartyNameSetRequestMessage(uint partyId, string partyName)
         : base(partyId)
        {
            this.partyName = partyName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUTF(partyName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            partyName = reader.ReadUTF();
            

}


}


}