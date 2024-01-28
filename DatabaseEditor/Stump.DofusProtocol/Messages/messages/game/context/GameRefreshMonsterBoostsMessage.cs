



















// Generated on 04/20/2016 12:03:23
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRefreshMonsterBoostsMessage : Message
{

public const ushort Id = 6618;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<MonsterBoosts> monsterBoosts;
        public IEnumerable<MonsterBoosts> familyBoosts;
        

public GameRefreshMonsterBoostsMessage()
{
}

public GameRefreshMonsterBoostsMessage(IEnumerable<MonsterBoosts> monsterBoosts, IEnumerable<MonsterBoosts> familyBoosts)
        {
            this.monsterBoosts = monsterBoosts;
            this.familyBoosts = familyBoosts;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)monsterBoosts.Count());
            foreach (var entry in monsterBoosts)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)familyBoosts.Count());
            foreach (var entry in familyBoosts)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            monsterBoosts = new MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 (monsterBoosts as MonsterBoosts[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            familyBoosts = new MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 (familyBoosts as MonsterBoosts[])[i].Deserialize(reader);
            }
            

}


}


}