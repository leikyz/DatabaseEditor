



















// Generated on 04/20/2016 12:03:27
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChallengeTargetsListMessage : Message
{

public const ushort Id = 5613;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<double> targetIds;
        public IEnumerable<short> targetCells;
        

public ChallengeTargetsListMessage()
{
}

public ChallengeTargetsListMessage(IEnumerable<double> targetIds, IEnumerable<short> targetCells)
        {
            this.targetIds = targetIds;
            this.targetCells = targetCells;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)targetIds.Count());
            foreach (var entry in targetIds)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteUShort((ushort)targetCells.Count());
            foreach (var entry in targetCells)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            targetIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (targetIds as double[])[i] = reader.ReadDouble();
            }
            limit = reader.ReadUShort();
            targetCells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (targetCells as short[])[i] = reader.ReadShort();
            }
            

}


}


}