



















// Generated on 04/20/2016 12:03:52
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareCanceledMessage : Message
{

public const ushort Id = 6679;
public override ushort MessageId
{
    get { return Id; }
}

public double dareId;
        

public DareCanceledMessage()
{
}

public DareCanceledMessage(double dareId)
        {
            this.dareId = dareId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(dareId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

dareId = reader.ReadDouble();
            if (dareId < 0 || dareId > 9.007199254740992E15)
                throw new Exception("Forbidden value on dareId = " + dareId + ", it doesn't respect the following condition : dareId < 0 || dareId > 9.007199254740992E15");
            

}


}


}