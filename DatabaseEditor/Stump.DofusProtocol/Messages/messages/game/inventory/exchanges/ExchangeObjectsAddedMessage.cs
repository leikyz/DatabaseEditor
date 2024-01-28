



















// Generated on 04/20/2016 12:04:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeObjectsAddedMessage : ExchangeObjectMessage
{

public const ushort Id = 6535;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<ObjectItem> @object;
        

public ExchangeObjectsAddedMessage()
{
}

public ExchangeObjectsAddedMessage(bool remote, IEnumerable<ObjectItem> @object)
         : base(remote)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)@object.Count());
            foreach (var entry in @object)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            @object = new ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (@object as ObjectItem[])[i].Deserialize(reader);
            }
            

}


}


}