



















// Generated on 04/20/2016 12:03:22
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameMapChangeOrientationsMessage : Message
{

public const ushort Id = 6155;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ActorOrientation> orientations;
        

public GameMapChangeOrientationsMessage()
{
}

public GameMapChangeOrientationsMessage(IEnumerable<ActorOrientation> orientations)
        {
            this.orientations = orientations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)orientations.Count());
            foreach (var entry in orientations)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            orientations = new ActorOrientation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (orientations as ActorOrientation[])[i].Deserialize(reader);
            }
            

}


}


}