



















// Generated on 04/20/2016 12:03:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
{

public const ushort Id = 6551;
public override ushort MessageId
{
    get { return Id; }
}

public Types.RemodelingInformation remodel;
        

public CharacterReplayWithRemodelRequestMessage()
{
}

public CharacterReplayWithRemodelRequestMessage(ulong characterId, Types.RemodelingInformation remodel)
         : base(characterId)
        {
            this.remodel = remodel;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            remodel.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
            

}


}


}