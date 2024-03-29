



















// Generated on 04/20/2016 12:04:01
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
{

public const ushort Id = 6235;
public override ushort MessageId
{
    get { return Id; }
}

public int replacedCharacterId;
        

public GuildFightTakePlaceRequestMessage()
{
}

public GuildFightTakePlaceRequestMessage(int taxCollectorId, int replacedCharacterId)
         : base(taxCollectorId)
        {
            this.replacedCharacterId = replacedCharacterId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(replacedCharacterId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            replacedCharacterId = reader.ReadInt();
            

}


}


}