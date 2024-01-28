



















// Generated on 04/20/2016 12:03:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const ushort Id = 5825;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.GameFightFighterInformations> summons;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(ushort actionId, double sourceId, IEnumerable<Types.GameFightFighterInformations> summons)
         : base(actionId, sourceId)
        {
            this.summons = summons;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)summons.Count());
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            summons = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (summons as Types.GameFightFighterInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
                 (summons as Types.GameFightFighterInformations[])[i].Deserialize(reader);
            }
            

}


}


}