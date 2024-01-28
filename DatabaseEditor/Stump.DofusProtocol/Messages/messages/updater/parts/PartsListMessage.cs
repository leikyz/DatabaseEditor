



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PartsListMessage : Message
{

public const ushort Id = 1502;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ContentPart> parts;
        

public PartsListMessage()
{
}

public PartsListMessage(IEnumerable<ContentPart> parts)
        {
            this.parts = parts;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)parts.Count());
            foreach (var entry in parts)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            parts = new ContentPart[limit];
            for (int i = 0; i < limit; i++)
            {
                 (parts as ContentPart[])[i].Deserialize(reader);
            }
            

}


}


}