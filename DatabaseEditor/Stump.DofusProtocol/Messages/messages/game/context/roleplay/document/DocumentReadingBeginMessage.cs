



















// Generated on 04/20/2016 12:03:33
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DocumentReadingBeginMessage : Message
{

public const ushort Id = 5675;
public override ushort MessageId
{
    get { return Id; }
}

public ushort documentId;
        

public DocumentReadingBeginMessage()
{
}

public DocumentReadingBeginMessage(ushort documentId)
        {
            this.documentId = documentId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(documentId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

documentId = reader.ReadVarUhShort();
            if (documentId < 0)
                throw new Exception("Forbidden value on documentId = " + documentId + ", it doesn't respect the following condition : documentId < 0");
            

}


}


}