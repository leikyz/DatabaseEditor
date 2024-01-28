



















// Generated on 04/20/2016 12:03:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
{

public const ushort Id = 6215;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<GameFightResumeSlaveInfo> slavesInfo;
        

public GameFightResumeWithSlavesMessage()
{
}

public GameFightResumeWithSlavesMessage(IEnumerable<FightDispellableEffectExtendedInformations> effects, IEnumerable<GameActionMark> marks, ushort gameTurn, int fightStart, IEnumerable<Idol> idols, IEnumerable<GameFightSpellCooldown> spellCooldowns, sbyte summonCount, sbyte bombCount, IEnumerable<GameFightResumeSlaveInfo> slavesInfo)
         : base(effects, marks, gameTurn, fightStart, idols, spellCooldowns, summonCount, bombCount)
        {
            this.slavesInfo = slavesInfo;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)slavesInfo.Count());
            foreach (var entry in slavesInfo)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            slavesInfo = new GameFightResumeSlaveInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (slavesInfo as GameFightResumeSlaveInfo[])[i].Deserialize(reader);
            }
            

}


}


}