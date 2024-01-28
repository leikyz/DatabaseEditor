



















// Generated on 04/20/2016 12:03:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameFightTurnListMessage : Message
{

public const ushort Id = 713;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<double> ids;
        public IEnumerable<double> deadsIds;
        

public GameFightTurnListMessage()
{
}

public GameFightTurnListMessage(IEnumerable<double> ids, IEnumerable<double> deadsIds)
        {
            this.ids = ids;
            this.deadsIds = deadsIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)ids.Count());
            foreach (var entry in ids)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteUShort((ushort)deadsIds.Count());
            foreach (var entry in deadsIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            ids = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ids as double[])[i] = reader.ReadDouble();
            }
            limit = reader.ReadUShort();
            deadsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (deadsIds as double[])[i] = reader.ReadDouble();
            }
            

}


}


}