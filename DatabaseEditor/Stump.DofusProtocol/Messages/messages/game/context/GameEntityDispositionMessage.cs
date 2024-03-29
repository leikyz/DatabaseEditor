



















// Generated on 04/20/2016 12:03:22
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameEntityDispositionMessage : Message
{

public const ushort Id = 5693;
public override ushort MessageId
{
    get { return Id; }
}

public Types.IdentifiedEntityDispositionInformations disposition;
        

public GameEntityDispositionMessage()
{
}

public GameEntityDispositionMessage(Types.IdentifiedEntityDispositionInformations disposition)
        {
            this.disposition = disposition;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

disposition.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

disposition = new Types.IdentifiedEntityDispositionInformations();
            disposition.Deserialize(reader);
            

}


}


}