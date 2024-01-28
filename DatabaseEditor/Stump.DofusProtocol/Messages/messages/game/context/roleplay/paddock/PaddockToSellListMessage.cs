



















// Generated on 04/20/2016 12:03:43
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class PaddockToSellListMessage : Message
{

public const ushort Id = 6138;
public override ushort MessageId
{
    get { return Id; }
}

public ushort pageIndex;
        public ushort totalPage;
        public IEnumerable<PaddockInformationsForSell> paddockList;
        

public PaddockToSellListMessage()
{
}

public PaddockToSellListMessage(ushort pageIndex, ushort totalPage, IEnumerable<PaddockInformationsForSell> paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(pageIndex);
            writer.WriteVarUhShort(totalPage);
            writer.WriteUShort((ushort)paddockList.Count());
            foreach (var entry in paddockList)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

pageIndex = reader.ReadVarUhShort();
            if (pageIndex < 0)
                throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            totalPage = reader.ReadVarUhShort();
            if (totalPage < 0)
                throw new Exception("Forbidden value on totalPage = " + totalPage + ", it doesn't respect the following condition : totalPage < 0");
            var limit = reader.ReadUShort();
            paddockList = new PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddockList as PaddockInformationsForSell[])[i].Deserialize(reader);
            }
            

}


}


}