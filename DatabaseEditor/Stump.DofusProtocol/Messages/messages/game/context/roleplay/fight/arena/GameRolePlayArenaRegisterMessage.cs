



















// Generated on 04/20/2016 12:03:35
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayArenaRegisterMessage : Message
{

public const ushort Id = 6280;
public override ushort MessageId
{
    get { return Id; }
}

public int battleMode;
        

public GameRolePlayArenaRegisterMessage()
{
}

public GameRolePlayArenaRegisterMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(battleMode);
            

}

public override void Deserialize(ICustomDataInput reader)
{

battleMode = reader.ReadInt();
            if (battleMode < 0)
                throw new Exception("Forbidden value on battleMode = " + battleMode + ", it doesn't respect the following condition : battleMode < 0");
            

}


}


}