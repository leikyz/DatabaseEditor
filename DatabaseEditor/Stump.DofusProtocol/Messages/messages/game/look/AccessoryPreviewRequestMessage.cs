



















// Generated on 04/20/2016 12:04:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AccessoryPreviewRequestMessage : Message
{

public const ushort Id = 6518;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ushort> genericId;
        

public AccessoryPreviewRequestMessage()
{
}

public AccessoryPreviewRequestMessage(IEnumerable<ushort> genericId)
        {
            this.genericId = genericId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)genericId.Count());
            foreach (var entry in genericId)
            {
                 writer.WriteVarUhShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            genericId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (genericId as ushort[])[i] = reader.ReadVarUhShort();
            }
            

}


}


}