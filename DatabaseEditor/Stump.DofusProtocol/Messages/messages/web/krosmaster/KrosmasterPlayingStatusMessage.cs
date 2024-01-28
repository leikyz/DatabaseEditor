



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class KrosmasterPlayingStatusMessage : Message
{

public const ushort Id = 6347;
public override ushort MessageId
{
    get { return Id; }
}

public bool playing;
        

public KrosmasterPlayingStatusMessage()
{
}

public KrosmasterPlayingStatusMessage(bool playing)
        {
            this.playing = playing;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(playing);
            

}

public override void Deserialize(ICustomDataInput reader)
{

playing = reader.ReadBoolean();
            

}


}


}