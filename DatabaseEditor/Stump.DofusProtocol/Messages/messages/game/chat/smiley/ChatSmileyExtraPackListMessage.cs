



















// Generated on 04/20/2016 12:03:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ChatSmileyExtraPackListMessage : Message
{

public const ushort Id = 6596;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<sbyte> packIds;
        

public ChatSmileyExtraPackListMessage()
{
}

public ChatSmileyExtraPackListMessage(IEnumerable<sbyte> packIds)
        {
            this.packIds = packIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)packIds.Count());
            foreach (var entry in packIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            packIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (packIds as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}