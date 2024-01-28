



















// Generated on 04/20/2016 12:04:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DecraftResultMessage : Message
{

public const ushort Id = 6569;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<DecraftedItemStackInfo> results;
        

public DecraftResultMessage()
{
}

public DecraftResultMessage(IEnumerable<DecraftedItemStackInfo> results)
        {
            this.results = results;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)results.Count());
            foreach (var entry in results)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            results = new DecraftedItemStackInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (results as DecraftedItemStackInfo[])[i].Deserialize(reader);
            }
            

}


}


}