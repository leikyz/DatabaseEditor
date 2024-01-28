



















// Generated on 04/20/2016 12:03:51
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PortalUseRequestMessage : Message
{

public const ushort Id = 6492;
public override ushort MessageId
{
    get { return Id; }
}

public uint portalId;
        

public PortalUseRequestMessage()
{
}

public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(portalId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

portalId = reader.ReadVarUhInt();
            if (portalId < 0)
                throw new Exception("Forbidden value on portalId = " + portalId + ", it doesn't respect the following condition : portalId < 0");
            

}


}


}