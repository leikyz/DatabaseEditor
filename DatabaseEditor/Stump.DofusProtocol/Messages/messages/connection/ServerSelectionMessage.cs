



















// Generated on 04/20/2016 12:03:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ServerSelectionMessage : Message
{

public const ushort Id = 40;
public override ushort MessageId
{
    get { return Id; }
}

public ushort serverId;
        

public ServerSelectionMessage()
{
}

public ServerSelectionMessage(ushort serverId)
        {
            this.serverId = serverId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(serverId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

serverId = reader.ReadVarUhShort();
            if (serverId < 0)
                throw new Exception("Forbidden value on serverId = " + serverId + ", it doesn't respect the following condition : serverId < 0");
            

}


}


}