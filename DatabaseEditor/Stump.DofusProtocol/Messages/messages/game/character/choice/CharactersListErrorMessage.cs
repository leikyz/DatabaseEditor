



















// Generated on 04/20/2016 12:03:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharactersListErrorMessage : Message
{

public const ushort Id = 5545;
public override ushort MessageId
{
    get { return Id; }
}



public CharactersListErrorMessage()
{
}



public override void Serialize(ICustomDataOutput writer)
{



}

public override void Deserialize(ICustomDataInput reader)
{



}


}


}