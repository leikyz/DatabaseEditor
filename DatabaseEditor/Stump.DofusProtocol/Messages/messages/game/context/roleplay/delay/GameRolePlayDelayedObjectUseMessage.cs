



















// Generated on 04/20/2016 12:03:33
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
{

public const ushort Id = 6425;
public override ushort MessageId
{
    get { return Id; }
}

public ushort objectGID;
        

public GameRolePlayDelayedObjectUseMessage()
{
}

public GameRolePlayDelayedObjectUseMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime, ushort objectGID)
         : base(delayedCharacterId, delayTypeId, delayEndTime)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(objectGID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVarUhShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}