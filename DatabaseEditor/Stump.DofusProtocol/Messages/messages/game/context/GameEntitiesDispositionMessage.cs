



















// Generated on 04/20/2016 12:03:22
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameEntitiesDispositionMessage : Message
{

public const ushort Id = 5696;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<IdentifiedEntityDispositionInformations> dispositions;
        

public GameEntitiesDispositionMessage()
{
}

public GameEntitiesDispositionMessage(IEnumerable<IdentifiedEntityDispositionInformations> dispositions)
        {
            this.dispositions = dispositions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)dispositions.Count());
            foreach (var entry in dispositions)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            dispositions = new IdentifiedEntityDispositionInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dispositions as IdentifiedEntityDispositionInformations[])[i].Deserialize(reader);
            }
            

}


}


}