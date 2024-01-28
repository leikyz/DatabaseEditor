



















// Generated on 04/20/2016 12:04:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ServerExperienceModificatorMessage : Message
{

public const ushort Id = 6237;
public override ushort MessageId
{
    get { return Id; }
}

public ushort experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(ushort experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(experiencePercent);
            

}

public override void Deserialize(ICustomDataInput reader)
{

experiencePercent = reader.ReadVarUhShort();
            if (experiencePercent < 0)
                throw new Exception("Forbidden value on experiencePercent = " + experiencePercent + ", it doesn't respect the following condition : experiencePercent < 0");
            

}


}


}