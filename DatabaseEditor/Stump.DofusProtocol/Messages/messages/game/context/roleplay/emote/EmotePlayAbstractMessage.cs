



















// Generated on 04/20/2016 12:03:33
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class EmotePlayAbstractMessage : Message
{

public const ushort Id = 5690;
public override ushort MessageId
{
    get { return Id; }
}

public byte emoteId;
        public double emoteStartTime;
        

public EmotePlayAbstractMessage()
{
}

public EmotePlayAbstractMessage(byte emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteByte(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public override void Deserialize(ICustomDataInput reader)
{

emoteId = reader.ReadByte();
            if (emoteId < 0 || emoteId > 255)
                throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0 || emoteId > 255");
            emoteStartTime = reader.ReadDouble();
            if (emoteStartTime < -9.007199254740992E15 || emoteStartTime > 9.007199254740992E15)
                throw new Exception("Forbidden value on emoteStartTime = " + emoteStartTime + ", it doesn't respect the following condition : emoteStartTime < -9.007199254740992E15 || emoteStartTime > 9.007199254740992E15");
            

}


}


}