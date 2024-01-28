



















// Generated on 04/20/2016 12:03:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class CharacterCreationRequestMessage : Message
{

public const ushort Id = 160;
public override ushort MessageId
{
    get { return Id; }
}

public string name;
        public byte breed;
        public bool sex;
        public IEnumerable<int> colors;
        public ushort cosmeticId;
        

public CharacterCreationRequestMessage()
{
}

public CharacterCreationRequestMessage(string name, byte breed, bool sex, IEnumerable<int> colors, ushort cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(name);
            writer.WriteByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteUShort((ushort)colors.Count());
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarUhShort(cosmeticId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

name = reader.ReadUTF();
            breed = reader.ReadByte();
            if (breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Huppermage)
                throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Huppermage");
            sex = reader.ReadBoolean();
            var limit = 5;
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (colors as int[])[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVarUhShort();
            if (cosmeticId < 0)
                throw new Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            

}


}


}