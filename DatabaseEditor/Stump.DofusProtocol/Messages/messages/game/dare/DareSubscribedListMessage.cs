



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareSubscribedListMessage : Message
{

public const ushort Id = 6658;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<DareInformations> daresFixedInfos;
        public IEnumerable<DareVersatileInformations> daresVersatilesInfos;
        

public DareSubscribedListMessage()
{
}

public DareSubscribedListMessage(IEnumerable<DareInformations> daresFixedInfos, IEnumerable<DareVersatileInformations> daresVersatilesInfos)
        {
            this.daresFixedInfos = daresFixedInfos;
            this.daresVersatilesInfos = daresVersatilesInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)daresFixedInfos.Count());
            foreach (var entry in daresFixedInfos)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)daresVersatilesInfos.Count());
            foreach (var entry in daresVersatilesInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            daresFixedInfos = new DareInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (daresFixedInfos as DareInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            daresVersatilesInfos = new DareVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (daresVersatilesInfos as DareVersatileInformations[])[i].Deserialize(reader);
            }
            

}


}


}