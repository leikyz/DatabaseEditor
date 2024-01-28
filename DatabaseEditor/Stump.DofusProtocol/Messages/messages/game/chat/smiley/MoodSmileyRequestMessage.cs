



















// Generated on 04/20/2016 12:03:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MoodSmileyRequestMessage : Message
{

public const ushort Id = 6192;
public override ushort MessageId
{
    get { return Id; }
}

public ushort smileyId;
        

public MoodSmileyRequestMessage()
{
}

public MoodSmileyRequestMessage(ushort smileyId)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(smileyId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

smileyId = reader.ReadVarUhShort();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}