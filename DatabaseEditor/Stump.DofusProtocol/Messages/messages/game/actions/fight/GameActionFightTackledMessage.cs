



















// Generated on 04/20/2016 12:03:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameActionFightTackledMessage : AbstractGameActionMessage
{

public const ushort Id = 1004;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<double> tacklersIds;
        

public GameActionFightTackledMessage()
{
}

public GameActionFightTackledMessage(ushort actionId, double sourceId, IEnumerable<double> tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)tacklersIds.Count());
            foreach (var entry in tacklersIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            tacklersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (tacklersIds as double[])[i] = reader.ReadDouble();
            }
            

}


}


}