



















// Generated on 04/20/2016 12:04:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PrismsInfoValidMessage : Message
{

public const ushort Id = 6451;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<PrismFightersInformation> fights;
        

public PrismsInfoValidMessage()
{
}

public PrismsInfoValidMessage(IEnumerable<PrismFightersInformation> fights)
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
            fights = new PrismFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fights as PrismFightersInformation[])[i].Deserialize(reader);
            }
            

}


}


}