



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
{

public const ushort Id = 5979;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<MountClientData> paddockedMountsDescription;
        

public ExchangeStartOkMountMessage()
{
}

public ExchangeStartOkMountMessage(IEnumerable<MountClientData> stabledMountsDescription, IEnumerable<MountClientData> paddockedMountsDescription)
         : base(stabledMountsDescription)
        {
            this.paddockedMountsDescription = paddockedMountsDescription;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)paddockedMountsDescription.Count());
            foreach (var entry in paddockedMountsDescription)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            paddockedMountsDescription = new MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddockedMountsDescription as MountClientData[])[i].Deserialize(reader);
            }
            

}


}


}