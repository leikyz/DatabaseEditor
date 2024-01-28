



















// Generated on 04/20/2016 12:03:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionAcknowledgementMessage : Message
{

public const ushort Id = 957;
public override ushort MessageId
{
    get { return Id; }
}

public bool valid;
        public sbyte actionId;
        

public GameActionAcknowledgementMessage()
{
}

public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(valid);
            writer.WriteSByte(actionId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

valid = reader.ReadBoolean();
            actionId = reader.ReadSByte();
            

}


}


}