



















// Generated on 04/20/2016 12:04:09
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeMountsStableRemoveMessage : Message
{

public const ushort Id = 6556;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<int> mountsId;
        

public ExchangeMountsStableRemoveMessage()
{
}

public ExchangeMountsStableRemoveMessage(IEnumerable<int> mountsId)
        {
            this.mountsId = mountsId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)mountsId.Count());
            foreach (var entry in mountsId)
            {
                 writer.WriteVarInt(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            mountsId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (mountsId as int[])[i] = reader.ReadVarInt();
            }
            

}


}


}