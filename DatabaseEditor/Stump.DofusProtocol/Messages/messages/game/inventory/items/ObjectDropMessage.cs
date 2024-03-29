



















// Generated on 04/20/2016 12:04:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectDropMessage : Message
{

public const ushort Id = 3005;
public override ushort MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectDropMessage()
{
}

public ObjectDropMessage(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(objectUID);
            writer.WriteVarUhInt(quantity);
            

}

public override void Deserialize(ICustomDataInput reader)
{

objectUID = reader.ReadVarUhInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}