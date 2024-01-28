



















// Generated on 04/20/2016 12:03:40
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobCrafterDirectoryListRequestMessage : Message
{

public const ushort Id = 6047;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte jobId;
        

public JobCrafterDirectoryListRequestMessage()
{
}

public JobCrafterDirectoryListRequestMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(jobId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            

}


}


}