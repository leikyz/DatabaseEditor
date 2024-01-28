



















// Generated on 04/20/2016 12:03:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ReloginTokenStatusMessage : Message
{

public const ushort Id = 6539;
public override ushort MessageId
{
    get { return Id; }
}

public bool validToken;
        public IEnumerable<sbyte> ticket;
        

public ReloginTokenStatusMessage()
{
}

public ReloginTokenStatusMessage(bool validToken, IEnumerable<sbyte> ticket)
        {
            this.validToken = validToken;
            this.ticket = ticket;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUShort((ushort)ticket.Count());
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

validToken = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ticket as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}