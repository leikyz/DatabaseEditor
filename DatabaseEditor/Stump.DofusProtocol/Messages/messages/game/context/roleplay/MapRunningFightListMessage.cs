



















// Generated on 04/20/2016 12:03:32
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MapRunningFightListMessage : Message
{

public const ushort Id = 5743;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<FightExternalInformations> fights;
        

public MapRunningFightListMessage()
{
}

public MapRunningFightListMessage(IEnumerable<FightExternalInformations> fights)
        {
            this.fights = fights;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)fights.Count());
            foreach (var entry in fights)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            fights = new FightExternalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fights as FightExternalInformations[])[i].Deserialize(reader);
            }
            

}


}


}