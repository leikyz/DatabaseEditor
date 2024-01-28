



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareListMessage : Message
{

public const ushort Id = 6661;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<DareInformations> dares;
        

public DareListMessage()
{
}

public DareListMessage(IEnumerable<DareInformations> dares)
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
            dares = new DareInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dares as DareInformations[])[i].Deserialize(reader);
            }
            

}


}


}