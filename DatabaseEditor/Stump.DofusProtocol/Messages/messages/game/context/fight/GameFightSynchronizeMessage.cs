



















// Generated on 04/20/2016 12:03:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightSynchronizeMessage : Message
{

public const ushort Id = 5921;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.GameFightFighterInformations> fighters;
        

public GameFightSynchronizeMessage()
{
}

public GameFightSynchronizeMessage(IEnumerable<Types.GameFightFighterInformations> fighters)
        {
            this.fighters = fighters;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)fighters.Count());
            foreach (var entry in fighters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            fighters = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fighters as Types.GameFightFighterInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
                 (fighters as Types.GameFightFighterInformations[])[i].Deserialize(reader);
            }
            

}


}


}