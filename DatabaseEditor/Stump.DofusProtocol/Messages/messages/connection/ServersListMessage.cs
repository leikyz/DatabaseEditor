



















// Generated on 04/20/2016 12:03:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ServersListMessage : Message
{

public const ushort Id = 30;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<GameServerInformations> servers;
        public ushort alreadyConnectedToServerId;
        public bool canCreateNewCharacter;
        

public ServersListMessage()
{
}

public ServersListMessage(IEnumerable<GameServerInformations> servers, ushort alreadyConnectedToServerId, bool canCreateNewCharacter)
        {
            this.servers = servers;
            this.alreadyConnectedToServerId = alreadyConnectedToServerId;
            this.canCreateNewCharacter = canCreateNewCharacter;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)servers.Count());
            foreach (var entry in servers)
            {
                entry.Serialize(writer);
            }
            writer.WriteVarUhShort(alreadyConnectedToServerId);
            writer.WriteBoolean(canCreateNewCharacter);
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            servers = new GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (servers as GameServerInformations[])[i].Deserialize(reader);
            }
            alreadyConnectedToServerId = reader.ReadVarUhShort();
            if (alreadyConnectedToServerId < 0)
                throw new Exception("Forbidden value on alreadyConnectedToServerId = " + alreadyConnectedToServerId + ", it doesn't respect the following condition : alreadyConnectedToServerId < 0");
            canCreateNewCharacter = reader.ReadBoolean();
            

}


}


}