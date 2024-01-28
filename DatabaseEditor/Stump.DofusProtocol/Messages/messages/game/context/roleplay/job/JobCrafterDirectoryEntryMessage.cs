



















// Generated on 04/20/2016 12:03:39
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobCrafterDirectoryEntryMessage : Message
{

public const ushort Id = 6044;
public override ushort MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public IEnumerable<JobCrafterDirectoryEntryJobInfo> jobInfoList;
        public Types.EntityLook playerLook;
        

public JobCrafterDirectoryEntryMessage()
{
}

public JobCrafterDirectoryEntryMessage(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, IEnumerable<JobCrafterDirectoryEntryJobInfo> jobInfoList, Types.EntityLook playerLook)
        {
            this.playerInfo = playerInfo;
            this.jobInfoList = jobInfoList;
            this.playerLook = playerLook;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

playerInfo.Serialize(writer);
            writer.WriteUShort((ushort)jobInfoList.Count());
            foreach (var entry in jobInfoList)
            {
                entry.Serialize(writer);
            }
            playerLook.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            var limit = reader.ReadUShort();
            jobInfoList = new JobCrafterDirectoryEntryJobInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobInfoList as JobCrafterDirectoryEntryJobInfo[])[i].Deserialize(reader);
            }
            playerLook = new Types.EntityLook();
            playerLook.Deserialize(reader);
            

}


}


}