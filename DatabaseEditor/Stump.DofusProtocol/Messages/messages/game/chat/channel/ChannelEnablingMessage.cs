



















// Generated on 04/20/2016 12:03:19
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChannelEnablingMessage : Message
{

public const ushort Id = 890;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte channel;
        public bool enable;
        

public ChannelEnablingMessage()
{
}

public ChannelEnablingMessage(sbyte channel, bool enable)
        {
            this.channel = channel;
            this.enable = enable;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(channel);
            writer.WriteBoolean(enable);
            

}

public override void Deserialize(ICustomDataInput reader)
{

channel = reader.ReadSByte();
            if (channel < 0)
                throw new Exception("Forbidden value on channel = " + channel + ", it doesn't respect the following condition : channel < 0");
            enable = reader.ReadBoolean();
            

}


}


}