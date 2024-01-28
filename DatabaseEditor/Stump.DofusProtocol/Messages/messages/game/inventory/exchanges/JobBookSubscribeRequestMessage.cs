



















// Generated on 04/20/2016 12:04:13
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobBookSubscribeRequestMessage : Message
{

public const ushort Id = 6592;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<sbyte> jobIds;
        

public JobBookSubscribeRequestMessage()
{
}

public JobBookSubscribeRequestMessage(IEnumerable<sbyte> jobIds)
        {
            this.jobIds = jobIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)jobIds.Count());
            foreach (var entry in jobIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            jobIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobIds as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}