



















// Generated on 04/20/2016 12:44:11
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GameRolePlayPrismInformations : GameRolePlayActorInformations
{

public const short Id = 161;
public override short TypeId
{
    get { return Id; }
}

public Types.PrismInformation prism;
        

public GameRolePlayPrismInformations()
{
}

public GameRolePlayPrismInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.PrismInformation prism)
         : base(contextualId, look, disposition)
        {
            this.prism = prism;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            prism = ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadShort());
            prism.Deserialize(reader);
            

}


}


}