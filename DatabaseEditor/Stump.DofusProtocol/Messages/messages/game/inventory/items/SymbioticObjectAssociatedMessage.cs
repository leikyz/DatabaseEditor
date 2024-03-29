



















// Generated on 04/20/2016 12:04:17
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SymbioticObjectAssociatedMessage : Message
{

public const ushort Id = 6527;
public override ushort MessageId
{
    get { return Id; }
}

public uint hostUID;
        

public SymbioticObjectAssociatedMessage()
{
}

public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(hostUID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

hostUID = reader.ReadVarUhInt();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            

}


}


}