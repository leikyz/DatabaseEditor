



















// Generated on 04/20/2016 12:03:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterSelectedSuccessMessage : Message
{

public const ushort Id = 153;
public override ushort MessageId
{
    get { return Id; }
}

public Types.CharacterBaseInformations infos;
        public bool isCollectingStats;
        

public CharacterSelectedSuccessMessage()
{
}

public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos, bool isCollectingStats)
        {
            this.infos = infos;
            this.isCollectingStats = isCollectingStats;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

infos.Serialize(writer);
            writer.WriteBoolean(isCollectingStats);
            

}

public override void Deserialize(ICustomDataInput reader)
{

infos = new Types.CharacterBaseInformations();
            infos.Deserialize(reader);
            isCollectingStats = reader.ReadBoolean();
            

}


}


}