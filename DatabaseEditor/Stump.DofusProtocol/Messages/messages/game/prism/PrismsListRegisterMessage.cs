



















// Generated on 04/20/2016 12:04:21
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PrismsListRegisterMessage : Message
{

public const ushort Id = 6441;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte listen;
        

public PrismsListRegisterMessage()
{
}

public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(listen);
            

}

public override void Deserialize(ICustomDataInput reader)
{

listen = reader.ReadSByte();
            if (listen < 0)
                throw new Exception("Forbidden value on listen = " + listen + ", it doesn't respect the following condition : listen < 0");
            

}


}


}