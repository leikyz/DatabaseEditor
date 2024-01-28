



















// Generated on 04/20/2016 12:04:03
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StatedMapUpdateMessage : Message
{

public const ushort Id = 5716;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<StatedElement> statedElements;
        

public StatedMapUpdateMessage()
{
}

public StatedMapUpdateMessage(IEnumerable<StatedElement> statedElements)
        {
            this.statedElements = statedElements;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)statedElements.Count());
            foreach (var entry in statedElements)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            statedElements = new StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                (statedElements as StatedElement[])[i].Deserialize(reader);
            }
            

}


}


}