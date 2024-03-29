



















// Generated on 04/20/2016 12:03:59
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildModificationStartedMessage : Message
{

public const ushort Id = 6324;
public override ushort MessageId
{
    get { return Id; }
}

public bool canChangeName;
        public bool canChangeEmblem;
        

public GuildModificationStartedMessage()
{
}

public GuildModificationStartedMessage(bool canChangeName, bool canChangeEmblem)
        {
            this.canChangeName = canChangeName;
            this.canChangeEmblem = canChangeEmblem;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, canChangeName);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canChangeEmblem);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(ICustomDataInput reader)
{

byte flag1 = reader.ReadByte();
            canChangeName = BooleanByteWrapper.GetFlag(flag1, 0);
            canChangeEmblem = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}