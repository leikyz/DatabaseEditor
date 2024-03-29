



















// Generated on 04/20/2016 12:03:55
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IgnoredListMessage : Message
{

public const ushort Id = 5674;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.IgnoredInformations> ignoredList;
        

public IgnoredListMessage()
{
}

public IgnoredListMessage(IEnumerable<Types.IgnoredInformations> ignoredList)
        {
            this.ignoredList = ignoredList;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)ignoredList.Count());
            foreach (var entry in ignoredList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            ignoredList = new Types.IgnoredInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ignoredList as Types.IgnoredInformations[])[i] = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
                 (ignoredList as Types.IgnoredInformations[])[i].Deserialize(reader);
            }
            

}


}


}