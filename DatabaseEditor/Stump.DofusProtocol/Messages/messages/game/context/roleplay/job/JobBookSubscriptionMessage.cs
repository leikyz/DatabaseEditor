



















// Generated on 04/20/2016 12:03:39
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class JobBookSubscriptionMessage : Message
{

public const ushort Id = 6593;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<JobBookSubscription> subscriptions;
        

public JobBookSubscriptionMessage()
{
}

public JobBookSubscriptionMessage(IEnumerable<JobBookSubscription> subscriptions)
        {
            this.subscriptions = subscriptions;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)subscriptions.Count());
            foreach (var entry in subscriptions)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            subscriptions = new JobBookSubscription[limit];
            for (int i = 0; i < limit; i++)
            {
                 (subscriptions as JobBookSubscription[])[i].Deserialize(reader);
            }
            

}


}


}