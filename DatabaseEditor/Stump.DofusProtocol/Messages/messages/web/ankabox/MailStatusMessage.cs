



















// Generated on 04/20/2016 12:04:26
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class MailStatusMessage : Message
{

public const ushort Id = 6275;
public override ushort MessageId
{
    get { return Id; }
}

public ushort unread;
        public ushort total;
        

public MailStatusMessage()
{
}

public MailStatusMessage(ushort unread, ushort total)
        {
            this.unread = unread;
            this.total = total;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(unread);
            writer.WriteVarUhShort(total);
            

}

public override void Deserialize(ICustomDataInput reader)
{

unread = reader.ReadVarUhShort();
            if (unread < 0)
                throw new Exception("Forbidden value on unread = " + unread + ", it doesn't respect the following condition : unread < 0");
            total = reader.ReadVarUhShort();
            if (total < 0)
                throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0");
            

}


}


}