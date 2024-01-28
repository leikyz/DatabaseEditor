



















// Generated on 04/20/2016 12:03:34
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayAttackMonsterRequestMessage : Message
{

public const ushort Id = 6191;
public override ushort MessageId
{
    get { return Id; }
}

public double monsterGroupId;
        

public GameRolePlayAttackMonsterRequestMessage()
{
}

public GameRolePlayAttackMonsterRequestMessage(double monsterGroupId)
        {
            this.monsterGroupId = monsterGroupId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(monsterGroupId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

monsterGroupId = reader.ReadDouble();
            if (monsterGroupId < -9.007199254740992E15 || monsterGroupId > 9.007199254740992E15)
                throw new Exception("Forbidden value on monsterGroupId = " + monsterGroupId + ", it doesn't respect the following condition : monsterGroupId < -9.007199254740992E15 || monsterGroupId > 9.007199254740992E15");
            

}


}


}