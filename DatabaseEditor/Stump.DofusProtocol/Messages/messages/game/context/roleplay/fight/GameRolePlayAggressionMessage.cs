



















// Generated on 04/20/2016 12:03:34
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayAggressionMessage : Message
{

public const ushort Id = 6073;
public override ushort MessageId
{
    get { return Id; }
}

public ulong attackerId;
        public ulong defenderId;
        

public GameRolePlayAggressionMessage()
{
}

public GameRolePlayAggressionMessage(ulong attackerId, ulong defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhLong(attackerId);
            writer.WriteVarUhLong(defenderId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

attackerId = reader.ReadVarUhLong();
            if (attackerId < 0 || attackerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on attackerId = " + attackerId + ", it doesn't respect the following condition : attackerId < 0 || attackerId > 9.007199254740992E15");
            defenderId = reader.ReadVarUhLong();
            if (defenderId < 0 || defenderId > 9.007199254740992E15)
                throw new Exception("Forbidden value on defenderId = " + defenderId + ", it doesn't respect the following condition : defenderId < 0 || defenderId > 9.007199254740992E15");
            

}


}


}