



















// Generated on 04/20/2016 12:03:28
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameDataPaddockObjectListAddMessage : Message
{

public const ushort Id = 5992;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<PaddockItem> paddockItemDescription;
        

public GameDataPaddockObjectListAddMessage()
{
}

public GameDataPaddockObjectListAddMessage(IEnumerable<PaddockItem> paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)paddockItemDescription.Count());
            foreach (var entry in paddockItemDescription)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            paddockItemDescription = new PaddockItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddockItemDescription as PaddockItem[])[i].Deserialize(reader);
            }
            

}


}


}