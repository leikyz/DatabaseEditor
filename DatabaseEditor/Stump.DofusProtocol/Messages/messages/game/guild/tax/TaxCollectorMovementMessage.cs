



















// Generated on 04/20/2016 12:04:01
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TaxCollectorMovementMessage : Message
{

public const ushort Id = 5633;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte movementType;
        public Types.TaxCollectorBasicInformations basicInfos;
        public ulong playerId;
        public string playerName;
        

public TaxCollectorMovementMessage()
{
}

public TaxCollectorMovementMessage(sbyte movementType, Types.TaxCollectorBasicInformations basicInfos, ulong playerId, string playerName)
        {
            this.movementType = movementType;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(movementType);
            basicInfos.Serialize(writer);
            writer.WriteVarUhLong(playerId);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

movementType = reader.ReadSByte();
            if (movementType < 0)
                throw new Exception("Forbidden value on movementType = " + movementType + ", it doesn't respect the following condition : movementType < 0");
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            playerName = reader.ReadUTF();
            

}


}


}