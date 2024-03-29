



















// Generated on 04/20/2016 12:03:55
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IgnoredAddedMessage : Message
{

public const ushort Id = 5678;
public override ushort MessageId
{
    get { return Id; }
}

public Types.IgnoredInformations ignoreAdded;
        public bool session;
        

public IgnoredAddedMessage()
{
}

public IgnoredAddedMessage(Types.IgnoredInformations ignoreAdded, bool session)
        {
            this.ignoreAdded = ignoreAdded;
            this.session = session;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(ignoreAdded.TypeId);
            ignoreAdded.Serialize(writer);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(ICustomDataInput reader)
{

ignoreAdded = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
            ignoreAdded.Deserialize(reader);
            session = reader.ReadBoolean();
            

}


}


}