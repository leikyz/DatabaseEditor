



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class KrosmasterInventoryMessage : Message
{

public const ushort Id = 6350;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<KrosmasterFigure> figures;
        

public KrosmasterInventoryMessage()
{
}

public KrosmasterInventoryMessage(IEnumerable<KrosmasterFigure> figures)
        {
            this.figures = figures;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)figures.Count());
            foreach (var entry in figures)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            figures = new KrosmasterFigure[limit];
            for (int i = 0; i < limit; i++)
            {
                 (figures as KrosmasterFigure[])[i].Deserialize(reader);
            }
            

}


}


}