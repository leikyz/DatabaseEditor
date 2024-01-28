



















// Generated on 04/20/2016 12:03:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AlmanachCalendarDateMessage : Message
{

public const ushort Id = 6341;
public override ushort MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(date);
            

}

public override void Deserialize(ICustomDataInput reader)
{

date = reader.ReadInt();
            

}


}


}