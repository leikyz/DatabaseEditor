



















// Generated on 04/20/2016 12:03:09
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class SequenceStartMessage : Message
{

public const ushort Id = 955;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte sequenceType;
        public double authorId;
        

public SequenceStartMessage()
{
}

public SequenceStartMessage(sbyte sequenceType, double authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(sequenceType);
            writer.WriteDouble(authorId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

sequenceType = reader.ReadSByte();
            authorId = reader.ReadDouble();
            if (authorId < -9.007199254740992E15 || authorId > 9.007199254740992E15)
                throw new Exception("Forbidden value on authorId = " + authorId + ", it doesn't respect the following condition : authorId < -9.007199254740992E15 || authorId > 9.007199254740992E15");
            

}


}


}