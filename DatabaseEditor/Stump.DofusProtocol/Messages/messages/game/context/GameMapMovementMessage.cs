



















// Generated on 04/20/2016 12:03:23
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameMapMovementMessage : Message
{

public const ushort Id = 951;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<short> keyMovements;
        public double actorId;
        

public GameMapMovementMessage()
{
}

public GameMapMovementMessage(IEnumerable<short> keyMovements, double actorId)
        {
            this.keyMovements = keyMovements;
            this.actorId = actorId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)keyMovements.Count());
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteDouble(actorId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (keyMovements as short[])[i] = reader.ReadShort();
            }
            actorId = reader.ReadDouble();
            if (actorId < -9.007199254740992E15 || actorId > 9.007199254740992E15)
                throw new Exception("Forbidden value on actorId = " + actorId + ", it doesn't respect the following condition : actorId < -9.007199254740992E15 || actorId > 9.007199254740992E15");
            

}


}


}