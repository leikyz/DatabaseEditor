



















// Generated on 04/20/2016 12:03:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class LocalizedChatSmileyMessage : ChatSmileyMessage
{

public const ushort Id = 6185;
public override ushort MessageId
{
    get { return Id; }
}

public ushort cellId;
        

public LocalizedChatSmileyMessage()
{
}

public LocalizedChatSmileyMessage(double entityId, ushort smileyId, int accountId, ushort cellId)
         : base(entityId, smileyId, accountId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(cellId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}