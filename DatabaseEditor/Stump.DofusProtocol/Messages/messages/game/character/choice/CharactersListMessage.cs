



















// Generated on 04/20/2016 12:03:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharactersListMessage : BasicCharactersListMessage
{

public const ushort Id = 151;
public override ushort MessageId
{
    get { return Id; }
}

public bool hasStartupActions;
        

public CharactersListMessage()
{
}

public CharactersListMessage(IEnumerable<Types.CharacterBaseInformations> characters, bool hasStartupActions)
         : base(characters)
        {
            this.hasStartupActions = hasStartupActions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteBoolean(hasStartupActions);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            hasStartupActions = reader.ReadBoolean();
            

}


}


}