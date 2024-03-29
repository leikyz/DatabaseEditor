



















// Generated on 04/20/2016 12:03:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharactersListWithModificationsMessage : CharactersListMessage
{

public const ushort Id = 6120;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<CharacterToRecolorInformation> charactersToRecolor;
        public IEnumerable<int> charactersToRename;
        public IEnumerable<int> unusableCharacters;
        public IEnumerable<CharacterToRelookInformation> charactersToRelook;
        

public CharactersListWithModificationsMessage()
{
}

public CharactersListWithModificationsMessage(IEnumerable<Types.CharacterBaseInformations> characters, bool hasStartupActions, IEnumerable<CharacterToRecolorInformation> charactersToRecolor, IEnumerable<int> charactersToRename, IEnumerable<int> unusableCharacters, IEnumerable<CharacterToRelookInformation> charactersToRelook)
         : base(characters, hasStartupActions)
        {
            this.charactersToRecolor = charactersToRecolor;
            this.charactersToRename = charactersToRename;
            this.unusableCharacters = unusableCharacters;
            this.charactersToRelook = charactersToRelook;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)charactersToRecolor.Count());
            foreach (var entry in charactersToRecolor)
            {
                entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)charactersToRename.Count());
            foreach (var entry in charactersToRename)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)unusableCharacters.Count());
            foreach (var entry in unusableCharacters)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)charactersToRelook.Count());
            foreach (var entry in charactersToRelook)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            charactersToRecolor = new CharacterToRecolorInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRecolor as CharacterToRecolorInformation[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            charactersToRename = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRename as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            unusableCharacters = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (unusableCharacters as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            charactersToRelook = new CharacterToRelookInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRelook as CharacterToRelookInformation[])[i].Deserialize(reader);
            }
            

}


}


}