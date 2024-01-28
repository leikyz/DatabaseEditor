



















// Generated on 04/20/2016 12:03:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightSpectateMessage : Message
{

public const ushort Id = 6069;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<FightDispellableEffectExtendedInformations> effects;
        public IEnumerable<GameActionMark> marks;
        public ushort gameTurn;
        public int fightStart;
        public IEnumerable<Idol> idols;
        

public GameFightSpectateMessage()
{
}

public GameFightSpectateMessage(IEnumerable<FightDispellableEffectExtendedInformations> effects, IEnumerable<GameActionMark> marks, ushort gameTurn, int fightStart, IEnumerable<Idol> idols)
        {
            this.effects = effects;
            this.marks = marks;
            this.gameTurn = gameTurn;
            this.fightStart = fightStart;
            this.idols = idols;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)effects.Count());
            foreach (var entry in effects)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)marks.Count());
            foreach (var entry in marks)
            {
                entry.Serialize(writer);
            }
            writer.WriteVarUhShort(gameTurn);
            writer.WriteInt(fightStart);
            writer.WriteUShort((ushort)idols.Count());
            foreach (var entry in idols)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            effects = new FightDispellableEffectExtendedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (effects as FightDispellableEffectExtendedInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            marks = new GameActionMark[limit];
            for (int i = 0; i < limit; i++)
            {
                 (marks as GameActionMark[])[i].Deserialize(reader);
            }
            gameTurn = reader.ReadVarUhShort();
            if (gameTurn < 0)
                throw new Exception("Forbidden value on gameTurn = " + gameTurn + ", it doesn't respect the following condition : gameTurn < 0");
            fightStart = reader.ReadInt();
            if (fightStart < 0)
                throw new Exception("Forbidden value on fightStart = " + fightStart + ", it doesn't respect the following condition : fightStart < 0");
            limit = reader.ReadUShort();
            idols = new Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idols as Idol[])[i].Deserialize(reader);
            }
            

}


}


}