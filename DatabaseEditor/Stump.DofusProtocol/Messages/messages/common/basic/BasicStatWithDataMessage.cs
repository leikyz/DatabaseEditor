



















// Generated on 04/20/2016 12:03:00
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class BasicStatWithDataMessage : BasicStatMessage
{

public const ushort Id = 6573;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.StatisticData> datas;
        

public BasicStatWithDataMessage()
{
}

public BasicStatWithDataMessage(double timeSpent, ushort statId, IEnumerable<Types.StatisticData> datas)
         : base(timeSpent, statId)
        {
            this.datas = datas;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)datas.Count());
            foreach (var entry in datas)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            datas = new Types.StatisticData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (datas as Types.StatisticData[])[i] = ProtocolTypeManager.GetInstance<Types.StatisticData>(reader.ReadShort());
                 (datas as Types.StatisticData[])[i].Deserialize(reader);
            }
            

}


}


}