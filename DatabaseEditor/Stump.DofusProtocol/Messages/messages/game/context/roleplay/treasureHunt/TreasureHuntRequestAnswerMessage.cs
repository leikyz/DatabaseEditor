



















// Generated on 04/20/2016 12:03:52
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class TreasureHuntRequestAnswerMessage : Message
{

public const ushort Id = 6489;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte result;
        

public TreasureHuntRequestAnswerMessage()
{
}

public TreasureHuntRequestAnswerMessage(sbyte questType, sbyte result)
        {
            this.questType = questType;
            this.result = result;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(questType);
            writer.WriteSByte(result);
            

}

public override void Deserialize(ICustomDataInput reader)
{

questType = reader.ReadSByte();
            if (questType < 0)
                throw new Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}