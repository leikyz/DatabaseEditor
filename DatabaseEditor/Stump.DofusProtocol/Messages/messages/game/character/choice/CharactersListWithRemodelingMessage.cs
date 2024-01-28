



















// Generated on 04/20/2016 12:03:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharactersListWithRemodelingMessage : CharactersListMessage
{

public const ushort Id = 6550;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<CharacterToRemodelInformations> charactersToRemodel;
        

public CharactersListWithRemodelingMessage()
{
}

public CharactersListWithRemodelingMessage(IEnumerable<Types.CharacterBaseInformations> characters, bool hasStartupActions, IEnumerable<CharacterToRemodelInformations> charactersToRemodel)
         : base(characters, hasStartupActions)
        {
            this.charactersToRemodel = charactersToRemodel;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)charactersToRemodel.Count());
            foreach (var entry in charactersToRemodel)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            charactersToRemodel = new CharacterToRemodelInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRemodel as CharacterToRemodelInformations[])[i].Deserialize(reader);
            }
            

}


}


}