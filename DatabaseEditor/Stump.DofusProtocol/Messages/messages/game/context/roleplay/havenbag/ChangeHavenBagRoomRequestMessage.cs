



















// Generated on 04/20/2016 12:03:35
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChangeHavenBagRoomRequestMessage : Message
{

public const ushort Id = 6638;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte roomId;
        

public ChangeHavenBagRoomRequestMessage()
{
}

public ChangeHavenBagRoomRequestMessage(sbyte roomId)
        {
            this.roomId = roomId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(roomId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

roomId = reader.ReadSByte();
            if (roomId < 0)
                throw new Exception("Forbidden value on roomId = " + roomId + ", it doesn't respect the following condition : roomId < 0");
            

}


}


}