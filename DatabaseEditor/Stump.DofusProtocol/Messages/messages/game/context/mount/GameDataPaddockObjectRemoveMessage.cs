



















// Generated on 04/20/2016 12:03:28
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameDataPaddockObjectRemoveMessage : Message
{

public const ushort Id = 5993;
public override ushort MessageId
{
    get { return Id; }
}

public ushort cellId;
        

public GameDataPaddockObjectRemoveMessage()
{
}

public GameDataPaddockObjectRemoveMessage(ushort cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(cellId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}