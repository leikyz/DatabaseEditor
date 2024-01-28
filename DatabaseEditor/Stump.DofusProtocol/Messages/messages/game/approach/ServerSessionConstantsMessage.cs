



















// Generated on 04/20/2016 12:03:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ServerSessionConstantsMessage : Message
{

public const ushort Id = 6434;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<Types.ServerSessionConstant> variables;
        

public ServerSessionConstantsMessage()
{
}

public ServerSessionConstantsMessage(IEnumerable<Types.ServerSessionConstant> variables)
        {
            this.variables = variables;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)variables.Count());
            foreach (var entry in variables)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            variables = new Types.ServerSessionConstant[limit];
            for (int i = 0; i < limit; i++)
            {
                 (variables as Types.ServerSessionConstant[])[i] = ProtocolTypeManager.GetInstance<Types.ServerSessionConstant>(reader.ReadShort());
                 (variables as Types.ServerSessionConstant[])[i].Deserialize(reader);
            }
            

}


}


}