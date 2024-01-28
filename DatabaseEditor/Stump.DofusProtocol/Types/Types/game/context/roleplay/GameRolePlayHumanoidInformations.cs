



















// Generated on 04/20/2016 12:44:10
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
{

public const short Id = 159;
public override short TypeId
{
    get { return Id; }
}

public Types.HumanInformations humanoidInfo;
        public int accountId;
        

public GameRolePlayHumanoidInformations()
{
}

public GameRolePlayHumanoidInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, Types.HumanInformations humanoidInfo, int accountId)
         : base(contextualId, look, disposition, name)
        {
            this.humanoidInfo = humanoidInfo;
            this.accountId = accountId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteShort(humanoidInfo.TypeId);
            humanoidInfo.Serialize(writer);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            humanoidInfo = ProtocolTypeManager.GetInstance<Types.HumanInformations>(reader.ReadShort());
            humanoidInfo.Deserialize(reader);
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}