



















// Generated on 04/20/2016 12:03:23
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameMapNoMovementMessage : Message
{

public const ushort Id = 954;
public override ushort MessageId
{
    get { return Id; }
}

public short cellX;
        public short cellY;
        

public GameMapNoMovementMessage()
{
}

public GameMapNoMovementMessage(short cellX, short cellY)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(cellX);
            writer.WriteShort(cellY);
            

}

public override void Deserialize(ICustomDataInput reader)
{

cellX = reader.ReadShort();
            cellY = reader.ReadShort();
            

}


}


}