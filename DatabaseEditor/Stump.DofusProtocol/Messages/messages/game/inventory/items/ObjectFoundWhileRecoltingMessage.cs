



















// Generated on 04/20/2016 12:04:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectFoundWhileRecoltingMessage : Message
{

public const ushort Id = 6017;
public override ushort MessageId
{
    get { return Id; }
}

public ushort genericId;
        public uint quantity;
        public uint resourceGenericId;
        

public ObjectFoundWhileRecoltingMessage()
{
}

public ObjectFoundWhileRecoltingMessage(ushort genericId, uint quantity, uint resourceGenericId)
        {
            this.genericId = genericId;
            this.quantity = quantity;
            this.resourceGenericId = resourceGenericId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(genericId);
            writer.WriteVarUhInt(quantity);
            writer.WriteVarUhInt(resourceGenericId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

genericId = reader.ReadVarUhShort();
            if (genericId < 0)
                throw new Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            resourceGenericId = reader.ReadVarUhInt();
            if (resourceGenericId < 0)
                throw new Exception("Forbidden value on resourceGenericId = " + resourceGenericId + ", it doesn't respect the following condition : resourceGenericId < 0");
            

}


}


}