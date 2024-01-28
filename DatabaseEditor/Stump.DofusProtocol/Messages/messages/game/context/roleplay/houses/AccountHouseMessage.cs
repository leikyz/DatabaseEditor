



















// Generated on 04/20/2016 12:03:37
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AccountHouseMessage : Message
{

public const ushort Id = 6315;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<AccountHouseInformations> houses;
        

public AccountHouseMessage()
{
}

public AccountHouseMessage(IEnumerable<AccountHouseInformations> houses)
        {
            this.houses = houses;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)houses.Count());
            foreach (var entry in houses)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            houses = new AccountHouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (houses as AccountHouseInformations[])[i].Deserialize(reader);
            }
            

}


}


}