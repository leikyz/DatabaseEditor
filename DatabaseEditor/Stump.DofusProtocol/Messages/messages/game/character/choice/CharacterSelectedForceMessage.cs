



















// Generated on 04/20/2016 12:03:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterSelectedForceMessage : Message
{

public const ushort Id = 6068;
public override ushort MessageId
{
    get { return Id; }
}

public int id;
        

public CharacterSelectedForceMessage()
{
}

public CharacterSelectedForceMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(ICustomDataInput reader)
{

id = reader.ReadInt();
            if (id < 1 || id > 2147483647)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 1 || id > 2147483647");
            

}


}


}