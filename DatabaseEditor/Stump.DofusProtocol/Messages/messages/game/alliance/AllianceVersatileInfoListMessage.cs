



















// Generated on 04/20/2016 12:03:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AllianceVersatileInfoListMessage : Message
{

public const ushort Id = 6436;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<AllianceVersatileInformations> alliances;
        

public AllianceVersatileInfoListMessage()
{
}

public AllianceVersatileInfoListMessage(IEnumerable<AllianceVersatileInformations> alliances)
        {
            this.alliances = alliances;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)alliances.Count());
            foreach (var entry in alliances)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            alliances = new AllianceVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alliances as AllianceVersatileInformations[])[i].Deserialize(reader);
            }
            

}


}


}