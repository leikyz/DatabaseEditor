



















// Generated on 04/20/2016 12:03:28
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightShowFighterMessage : Message
{

public const ushort Id = 5864;
public override ushort MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations informations;
        

public GameFightShowFighterMessage()
{
}

public GameFightShowFighterMessage(Types.GameFightFighterInformations informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

informations = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}