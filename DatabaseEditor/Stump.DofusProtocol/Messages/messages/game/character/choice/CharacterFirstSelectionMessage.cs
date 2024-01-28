



















// Generated on 04/20/2016 12:03:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterFirstSelectionMessage : CharacterSelectionMessage
{

public const ushort Id = 6084;
public override ushort MessageId
{
    get { return Id; }
}

public bool doTutorial;
        

public CharacterFirstSelectionMessage()
{
}

public CharacterFirstSelectionMessage(ulong id, bool doTutorial)
         : base(id)
        {
            this.doTutorial = doTutorial;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteBoolean(doTutorial);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            doTutorial = reader.ReadBoolean();
            

}


}


}