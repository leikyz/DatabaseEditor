



















// Generated on 04/20/2016 12:04:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class UpdateMapPlayersAgressableStatusMessage : Message
{

public const ushort Id = 6454;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ulong> playerIds;
        public IEnumerable<sbyte> enable;
        

public UpdateMapPlayersAgressableStatusMessage()
{
}

public UpdateMapPlayersAgressableStatusMessage(IEnumerable<ulong> playerIds, IEnumerable<sbyte> enable)
        {
            this.playerIds = playerIds;
            this.enable = enable;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)playerIds.Count());
            foreach (var entry in playerIds)
            {
                 writer.WriteVarUhLong(entry);
            }
            writer.WriteUShort((ushort)enable.Count());
            foreach (var entry in enable)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            playerIds = new ulong[limit];
            for (int i = 0; i < limit; i++)
            {
                 (playerIds as ulong[])[i] = reader.ReadVarUhLong();
            }
            limit = reader.ReadUShort();
            enable = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (enable as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}