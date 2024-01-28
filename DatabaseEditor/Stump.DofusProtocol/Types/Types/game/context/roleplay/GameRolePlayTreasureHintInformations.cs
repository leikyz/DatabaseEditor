



















// Generated on 04/20/2016 12:44:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
{

public const short Id = 471;
public override short TypeId
{
    get { return Id; }
}

public ushort npcId;
        

public GameRolePlayTreasureHintInformations()
{
}

public GameRolePlayTreasureHintInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId)
         : base(contextualId, look, disposition)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(npcId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
            if (npcId < 0)
                throw new Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < 0");
            

}


}


}