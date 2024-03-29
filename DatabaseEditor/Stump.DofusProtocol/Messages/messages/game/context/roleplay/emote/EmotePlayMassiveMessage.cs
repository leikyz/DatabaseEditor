



















// Generated on 04/20/2016 12:03:33
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
{

public const ushort Id = 5691;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<double> actorIds;
        

public EmotePlayMassiveMessage()
{
}

public EmotePlayMassiveMessage(byte emoteId, double emoteStartTime, IEnumerable<double> actorIds)
         : base(emoteId, emoteStartTime)
        {
            this.actorIds = actorIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)actorIds.Count());
            foreach (var entry in actorIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            actorIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (actorIds as double[])[i] = reader.ReadDouble();
            }
            

}


}


}