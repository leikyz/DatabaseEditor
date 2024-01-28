



















// Generated on 04/20/2016 12:04:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeMountsStableAddMessage : Message
{

public const ushort Id = 6555;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<MountClientData> mountDescription;
        

public ExchangeMountsStableAddMessage()
{
}

public ExchangeMountsStableAddMessage(IEnumerable<MountClientData> mountDescription)
        {
            this.mountDescription = mountDescription;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)mountDescription.Count());
            foreach (var entry in mountDescription)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            mountDescription = new MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (mountDescription as MountClientData[])[i].Deserialize(reader);
            }
            

}


}


}