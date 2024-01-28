



















// Generated on 04/20/2016 12:03:40
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobDescriptionMessage : Message
{

public const ushort Id = 5655;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<JobDescription> jobsDescription;
        

public JobDescriptionMessage()
{
}

public JobDescriptionMessage(IEnumerable<JobDescription> jobsDescription)
        {
            this.jobsDescription = jobsDescription;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)jobsDescription.Count());
            foreach (var entry in jobsDescription)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            jobsDescription = new JobDescription[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobsDescription as JobDescription[])[i].Deserialize(reader);
            }
            

}


}


}