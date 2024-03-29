



















// Generated on 04/20/2016 12:03:55
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class IgnoredDeleteResultMessage : Message
{

public const ushort Id = 5677;
public override ushort MessageId
{
    get { return Id; }
}

public bool success;
        public bool session;
        public string name;
        

public IgnoredDeleteResultMessage()
{
}

public IgnoredDeleteResultMessage(bool success, bool session, string name)
        {
            this.success = success;
            this.session = session;
            this.name = name;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, session);
            writer.WriteByte(flag1);
            writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataInput reader)
{

byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            session = BooleanByteWrapper.GetFlag(flag1, 1);
            name = reader.ReadUTF();
            

}


}


}