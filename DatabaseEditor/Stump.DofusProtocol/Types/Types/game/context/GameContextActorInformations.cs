



















// Generated on 04/20/2016 12:44:07
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class GameContextActorInformations
{

public const short Id = 150;
public virtual short TypeId
{
    get { return Id; }
}

public double contextualId;
        public Types.EntityLook look;
        public Types.EntityDispositionInformations disposition;
        

public GameContextActorInformations()
{
}

public GameContextActorInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
        {
            this.contextualId = contextualId;
            this.look = look;
            this.disposition = disposition;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(contextualId);
            look.Serialize(writer);
            writer.WriteShort(disposition.TypeId);
            disposition.Serialize(writer);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

contextualId = reader.ReadDouble();
            if (contextualId < -9.007199254740992E15 || contextualId > 9.007199254740992E15)
                throw new Exception("Forbidden value on contextualId = " + contextualId + ", it doesn't respect the following condition : contextualId < -9.007199254740992E15 || contextualId > 9.007199254740992E15");
            look = new Types.EntityLook();
            look.Deserialize(reader);
            disposition = ProtocolTypeManager.GetInstance<Types.EntityDispositionInformations>(reader.ReadShort());
            disposition.Deserialize(reader);
            

}


}


}