



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareSubscribedMessage : Message
{

public const ushort Id = 6660;
public override ushort MessageId
{
    get { return Id; }
}

public bool success;
        public bool subscribe;
        public double dareId;
        public Types.DareVersatileInformations dareVersatilesInfos;
        

public DareSubscribedMessage()
{
}

public DareSubscribedMessage(bool success, bool subscribe, double dareId, Types.DareVersatileInformations dareVersatilesInfos)
        {
            this.success = success;
            this.subscribe = subscribe;
            this.dareId = dareId;
            this.dareVersatilesInfos = dareVersatilesInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, subscribe);
            writer.WriteByte(flag1);
            writer.WriteDouble(dareId);
            dareVersatilesInfos.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            subscribe = BooleanByteWrapper.GetFlag(flag1, 1);
            dareId = reader.ReadDouble();
            if (dareId < 0 || dareId > 9.007199254740992E15)
                throw new Exception("Forbidden value on dareId = " + dareId + ", it doesn't respect the following condition : dareId < 0 || dareId > 9.007199254740992E15");
            dareVersatilesInfos = new Types.DareVersatileInformations();
            dareVersatilesInfos.Deserialize(reader);
            

}


}


}