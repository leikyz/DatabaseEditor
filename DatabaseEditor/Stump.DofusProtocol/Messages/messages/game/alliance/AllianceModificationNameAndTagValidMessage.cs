



















// Generated on 04/20/2016 12:03:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class AllianceModificationNameAndTagValidMessage : Message
{

public const ushort Id = 6449;
public override ushort MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        

public AllianceModificationNameAndTagValidMessage()
{
}

public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(ICustomDataInput reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            

}


}


}