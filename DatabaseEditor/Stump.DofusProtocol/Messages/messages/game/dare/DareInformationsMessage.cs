



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareInformationsMessage : Message
{

public const ushort Id = 6656;
public override ushort MessageId
{
    get { return Id; }
}

public Types.DareInformations dareFixedInfos;
        public Types.DareVersatileInformations dareVersatilesInfos;
        

public DareInformationsMessage()
{
}

public DareInformationsMessage(Types.DareInformations dareFixedInfos, Types.DareVersatileInformations dareVersatilesInfos)
        {
            this.dareFixedInfos = dareFixedInfos;
            this.dareVersatilesInfos = dareVersatilesInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

dareFixedInfos.Serialize(writer);
            dareVersatilesInfos.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

dareFixedInfos = new Types.DareInformations();
            dareFixedInfos.Deserialize(reader);
            dareVersatilesInfos = new Types.DareVersatileInformations();
            dareVersatilesInfos.Deserialize(reader);
            

}


}


}