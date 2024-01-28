



















// Generated on 04/20/2016 12:03:22
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameContextRemoveMultipleElementsMessage : Message
{

public const ushort Id = 252;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<double> id;
        

public GameContextRemoveMultipleElementsMessage()
{
}

public GameContextRemoveMultipleElementsMessage(IEnumerable<double> id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)id.Count());
            foreach (var entry in id)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            id = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (id as double[])[i] = reader.ReadDouble();
            }
            

}


}


}