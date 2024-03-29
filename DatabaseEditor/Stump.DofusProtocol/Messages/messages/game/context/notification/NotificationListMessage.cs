



















// Generated on 04/20/2016 12:03:31
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class NotificationListMessage : Message
{

public const ushort Id = 6087;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<int> flags;
        

public NotificationListMessage()
{
}

public NotificationListMessage(IEnumerable<int> flags)
        {
            this.flags = flags;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)flags.Count());
            foreach (var entry in flags)
            {
                 writer.WriteVarInt(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            flags = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (flags as int[])[i] = reader.ReadVarInt();
            }
            

}


}


}