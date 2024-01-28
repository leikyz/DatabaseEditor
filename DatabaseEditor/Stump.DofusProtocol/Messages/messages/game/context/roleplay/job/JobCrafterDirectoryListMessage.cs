



















// Generated on 04/20/2016 12:03:40
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobCrafterDirectoryListMessage : Message
{

public const ushort Id = 6046;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<JobCrafterDirectoryListEntry> listEntries;
        

public JobCrafterDirectoryListMessage()
{
}

public JobCrafterDirectoryListMessage(IEnumerable<JobCrafterDirectoryListEntry> listEntries)
        {
            this.listEntries = listEntries;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)listEntries.Count());
            foreach (var entry in listEntries)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            listEntries = new JobCrafterDirectoryListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 (listEntries as JobCrafterDirectoryListEntry[])[i].Deserialize(reader);
            }
            

}


}


}