



















// Generated on 04/20/2016 12:03:33
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ComicReadingBeginMessage : Message
{

public const ushort Id = 6536;
public override ushort MessageId
{
    get { return Id; }
}

public ushort comicId;
        

public ComicReadingBeginMessage()
{
}

public ComicReadingBeginMessage(ushort comicId)
        {
            this.comicId = comicId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(comicId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

comicId = reader.ReadVarUhShort();
            if (comicId < 0)
                throw new Exception("Forbidden value on comicId = " + comicId + ", it doesn't respect the following condition : comicId < 0");
            

}


}


}