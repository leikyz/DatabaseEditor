



















// Generated on 04/20/2016 12:03:40
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobCrafterDirectorySettingsMessage : Message
{

public const ushort Id = 5652;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<JobCrafterDirectorySettings> craftersSettings;
        

public JobCrafterDirectorySettingsMessage()
{
}

public JobCrafterDirectorySettingsMessage(IEnumerable<JobCrafterDirectorySettings> craftersSettings)
        {
            this.craftersSettings = craftersSettings;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)craftersSettings.Count());
            foreach (var entry in craftersSettings)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            craftersSettings = new JobCrafterDirectorySettings[limit];
            for (int i = 0; i < limit; i++)
            {
                 (craftersSettings as JobCrafterDirectorySettings[])[i].Deserialize(reader);
            }
            

}


}


}