



















// Generated on 04/20/2016 12:04:25
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CheckIntegrityMessage : Message
{

public const ushort Id = 6372;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<sbyte> data;
        

public CheckIntegrityMessage()
{
}

public CheckIntegrityMessage(IEnumerable<sbyte> data)
        {
            this.data = data;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)data.Count());
            foreach (var entry in data)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            data = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (data as sbyte[])[i] = reader.ReadSByte();
            }
            

}


}


}