



















// Generated on 04/20/2016 12:04:23
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class StartupActionsListMessage : Message
{

public const ushort Id = 1301;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<StartupActionAddObject> actions;
        

public StartupActionsListMessage()
{
}

public StartupActionsListMessage(IEnumerable<StartupActionAddObject> actions)
        {
            this.actions = actions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)actions.Count());
            foreach (var entry in actions)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            actions = new StartupActionAddObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 (actions as StartupActionAddObject[])[i].Deserialize(reader);
            }
            

}


}


}