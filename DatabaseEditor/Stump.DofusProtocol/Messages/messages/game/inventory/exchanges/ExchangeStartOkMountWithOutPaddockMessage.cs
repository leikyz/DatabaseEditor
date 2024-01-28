



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartOkMountWithOutPaddockMessage : Message
{

public const ushort Id = 5991;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<MountClientData> stabledMountsDescription;
        

public ExchangeStartOkMountWithOutPaddockMessage()
{
}

public ExchangeStartOkMountWithOutPaddockMessage(IEnumerable<MountClientData> stabledMountsDescription)
        {
            this.stabledMountsDescription = stabledMountsDescription;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)stabledMountsDescription.Count());
            foreach (var entry in stabledMountsDescription)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            stabledMountsDescription = new MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (stabledMountsDescription as MountClientData[])[i].Deserialize(reader);
            }
            

}


}


}