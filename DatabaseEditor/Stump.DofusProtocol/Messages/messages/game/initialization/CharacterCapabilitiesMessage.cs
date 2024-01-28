



















// Generated on 04/20/2016 12:04:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterCapabilitiesMessage : Message
{

public const ushort Id = 6339;
public override ushort MessageId
{
    get { return Id; }
}

public uint guildEmblemSymbolCategories;
        

public CharacterCapabilitiesMessage()
{
}

public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
        {
            this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(guildEmblemSymbolCategories);
            

}

public override void Deserialize(ICustomDataInput reader)
{

guildEmblemSymbolCategories = reader.ReadVarUhInt();
            if (guildEmblemSymbolCategories < 0)
                throw new Exception("Forbidden value on guildEmblemSymbolCategories = " + guildEmblemSymbolCategories + ", it doesn't respect the following condition : guildEmblemSymbolCategories < 0");
            

}


}


}