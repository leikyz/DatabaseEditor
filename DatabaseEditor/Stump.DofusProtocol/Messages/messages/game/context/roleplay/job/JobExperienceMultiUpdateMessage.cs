



















// Generated on 04/20/2016 12:03:40
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobExperienceMultiUpdateMessage : Message
{

public const ushort Id = 5809;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<JobExperience> experiencesUpdate;
        

public JobExperienceMultiUpdateMessage()
{
}

public JobExperienceMultiUpdateMessage(IEnumerable<JobExperience> experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)experiencesUpdate.Count());
            foreach (var entry in experiencesUpdate)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            experiencesUpdate = new JobExperience[limit];
            for (int i = 0; i < limit; i++)
            {
                 (experiencesUpdate as JobExperience[])[i].Deserialize(reader);
            }
            

}


}


}