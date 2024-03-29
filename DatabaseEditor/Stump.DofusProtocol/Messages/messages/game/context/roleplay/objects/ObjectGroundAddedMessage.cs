



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ObjectGroundAddedMessage : Message
{

public const ushort Id = 3017;
public override ushort MessageId
{
    get { return Id; }
}

public ushort cellId;
        public ushort objectGID;

        public ObjectGroundAddedMessage()
        {
        }
        public ObjectGroundAddedMessage(short id)
{
}

public ObjectGroundAddedMessage(ushort cellId, ushort objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(cellId);
            writer.WriteVarUhShort(objectGID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            objectGID = reader.ReadVarUhShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}