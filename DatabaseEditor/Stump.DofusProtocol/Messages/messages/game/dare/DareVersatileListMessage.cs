



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareVersatileListMessage : Message
{

public const ushort Id = 6657;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<DareVersatileInformations> dares;
        

public DareVersatileListMessage()
{
}

public DareVersatileListMessage(IEnumerable<DareVersatileInformations> dares)
        {
            this.dares = dares;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)dares.Count());
            foreach (var entry in dares)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            dares = new DareVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dares as DareVersatileInformations[])[i].Deserialize(reader);
            }
            

}


}


}