



















// Generated on 04/20/2016 12:03:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightStartMessage : Message
{

public const ushort Id = 712;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Idol> idols;
        

public GameFightStartMessage()
{
}

public GameFightStartMessage(IEnumerable<Idol> idols)
        {
            this.idols = idols;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)idols.Count());
            foreach (var entry in idols)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            idols = new Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idols as Idol[])[i].Deserialize(reader);
            }
            

}


}


}