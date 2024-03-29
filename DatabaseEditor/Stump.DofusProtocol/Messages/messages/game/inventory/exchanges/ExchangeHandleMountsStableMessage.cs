



















// Generated on 04/20/2016 12:04:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeHandleMountsStableMessage : Message
{

public const ushort Id = 6562;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte actionType;
        public IEnumerable<uint> ridesId;
        

public ExchangeHandleMountsStableMessage()
{
}

public ExchangeHandleMountsStableMessage(sbyte actionType, IEnumerable<uint> ridesId)
        {
            this.actionType = actionType;
            this.ridesId = ridesId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(actionType);
            writer.WriteUShort((ushort)ridesId.Count());
            foreach (var entry in ridesId)
            {
                 writer.WriteVarUhInt(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

actionType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            ridesId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ridesId as uint[])[i] = reader.ReadVarUhInt();
            }
            

}


}


}