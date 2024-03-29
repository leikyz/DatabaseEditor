



















// Generated on 04/20/2016 12:03:35
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GameRolePlayArenaSwitchToFightServerMessage : Message
{

public const ushort Id = 6575;
public override ushort MessageId
{
    get { return Id; }
}

public string address;
        public ushort port;
        public IEnumerable<sbyte> ticket;
        

public GameRolePlayArenaSwitchToFightServerMessage()
{
}

public GameRolePlayArenaSwitchToFightServerMessage(string address, ushort port, IEnumerable<sbyte> ticket)
        {
            this.address = address;
            this.port = port;
            this.ticket = ticket;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(address);
            writer.WriteUShort(port);
            writer.WriteUShort((ushort)ticket.Count());
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

address = reader.ReadUTF();
            port = reader.ReadUShort();
            if (port < 0 || port > 65535)
                throw new Exception("Forbidden value on port = " + port + ", it doesn't respect the following condition : port < 0 || port > 65535");
            var limit = reader.ReadUShort();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ticket as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}