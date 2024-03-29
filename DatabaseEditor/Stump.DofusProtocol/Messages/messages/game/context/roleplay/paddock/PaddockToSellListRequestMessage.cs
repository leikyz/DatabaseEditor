



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PaddockToSellListRequestMessage : Message
{

public const ushort Id = 6141;
public override ushort MessageId
{
    get { return Id; }
}

public ushort pageIndex;
        

public PaddockToSellListRequestMessage()
{
}

public PaddockToSellListRequestMessage(ushort pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(pageIndex);
            

}

public override void Deserialize(ICustomDataInput reader)
{

pageIndex = reader.ReadVarUhShort();
            if (pageIndex < 0)
                throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            

}


}


}