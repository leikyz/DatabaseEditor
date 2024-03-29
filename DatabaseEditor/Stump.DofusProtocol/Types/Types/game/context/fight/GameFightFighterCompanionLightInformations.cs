



















// Generated on 04/20/2016 12:44:09
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GameFightFighterCompanionLightInformations : GameFightFighterLightInformations
{

public const short Id = 454;
public override short TypeId
{
    get { return Id; }
}

public sbyte companionId;
        public double masterId;
        

public GameFightFighterCompanionLightInformations()
{
}

public GameFightFighterCompanionLightInformations(bool sex, bool alive, double id, sbyte wave, ushort level, sbyte breed, sbyte companionId, double masterId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.companionId = companionId;
            this.masterId = masterId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteSByte(companionId);
            writer.WriteDouble(masterId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            companionId = reader.ReadSByte();
            if (companionId < 0)
                throw new Exception("Forbidden value on companionId = " + companionId + ", it doesn't respect the following condition : companionId < 0");
            masterId = reader.ReadDouble();
            if (masterId < -9.007199254740992E15 || masterId > 9.007199254740992E15)
                throw new Exception("Forbidden value on masterId = " + masterId + ", it doesn't respect the following condition : masterId < -9.007199254740992E15 || masterId > 9.007199254740992E15");
            

}


}


}