



















// Generated on 04/20/2016 12:04:23
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TitleLostMessage : Message
{

public const ushort Id = 6371;
public override ushort MessageId
{
    get { return Id; }
}

public ushort titleId;
        

public TitleLostMessage()
{
}

public TitleLostMessage(ushort titleId)
        {
            this.titleId = titleId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(titleId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

titleId = reader.ReadVarUhShort();
            if (titleId < 0)
                throw new Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            

}


}


}