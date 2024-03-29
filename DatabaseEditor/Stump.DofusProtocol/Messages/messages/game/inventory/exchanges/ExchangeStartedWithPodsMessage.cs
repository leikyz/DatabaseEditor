



















// Generated on 04/20/2016 12:04:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
{

public const ushort Id = 6129;
public override ushort MessageId
{
    get { return Id; }
}

public double firstCharacterId;
        public uint firstCharacterCurrentWeight;
        public uint firstCharacterMaxWeight;
        public double secondCharacterId;
        public uint secondCharacterCurrentWeight;
        public uint secondCharacterMaxWeight;
        

public ExchangeStartedWithPodsMessage()
{
}

public ExchangeStartedWithPodsMessage(sbyte exchangeType, double firstCharacterId, uint firstCharacterCurrentWeight, uint firstCharacterMaxWeight, double secondCharacterId, uint secondCharacterCurrentWeight, uint secondCharacterMaxWeight)
         : base(exchangeType)
        {
            this.firstCharacterId = firstCharacterId;
            this.firstCharacterCurrentWeight = firstCharacterCurrentWeight;
            this.firstCharacterMaxWeight = firstCharacterMaxWeight;
            this.secondCharacterId = secondCharacterId;
            this.secondCharacterCurrentWeight = secondCharacterCurrentWeight;
            this.secondCharacterMaxWeight = secondCharacterMaxWeight;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteDouble(firstCharacterId);
            writer.WriteVarUhInt(firstCharacterCurrentWeight);
            writer.WriteVarUhInt(firstCharacterMaxWeight);
            writer.WriteDouble(secondCharacterId);
            writer.WriteVarUhInt(secondCharacterCurrentWeight);
            writer.WriteVarUhInt(secondCharacterMaxWeight);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            firstCharacterId = reader.ReadDouble();
            if (firstCharacterId < -9.007199254740992E15 || firstCharacterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on firstCharacterId = " + firstCharacterId + ", it doesn't respect the following condition : firstCharacterId < -9.007199254740992E15 || firstCharacterId > 9.007199254740992E15");
            firstCharacterCurrentWeight = reader.ReadVarUhInt();
            if (firstCharacterCurrentWeight < 0)
                throw new Exception("Forbidden value on firstCharacterCurrentWeight = " + firstCharacterCurrentWeight + ", it doesn't respect the following condition : firstCharacterCurrentWeight < 0");
            firstCharacterMaxWeight = reader.ReadVarUhInt();
            if (firstCharacterMaxWeight < 0)
                throw new Exception("Forbidden value on firstCharacterMaxWeight = " + firstCharacterMaxWeight + ", it doesn't respect the following condition : firstCharacterMaxWeight < 0");
            secondCharacterId = reader.ReadDouble();
            if (secondCharacterId < -9.007199254740992E15 || secondCharacterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on secondCharacterId = " + secondCharacterId + ", it doesn't respect the following condition : secondCharacterId < -9.007199254740992E15 || secondCharacterId > 9.007199254740992E15");
            secondCharacterCurrentWeight = reader.ReadVarUhInt();
            if (secondCharacterCurrentWeight < 0)
                throw new Exception("Forbidden value on secondCharacterCurrentWeight = " + secondCharacterCurrentWeight + ", it doesn't respect the following condition : secondCharacterCurrentWeight < 0");
            secondCharacterMaxWeight = reader.ReadVarUhInt();
            if (secondCharacterMaxWeight < 0)
                throw new Exception("Forbidden value on secondCharacterMaxWeight = " + secondCharacterMaxWeight + ", it doesn't respect the following condition : secondCharacterMaxWeight < 0");
            

}


}


}