



















// Generated on 04/20/2016 12:44:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class CharacterBaseCharacteristic
{

public const short Id = 4;
public virtual short TypeId
{
    get { return Id; }
}

public short @base;
        public short additionnal;
        public short objectsAndMountBonus;
        public short alignGiftBonus;
        public short contextModif;
        

public CharacterBaseCharacteristic()
{
}

public CharacterBaseCharacteristic(short @base, short additionnal, short objectsAndMountBonus, short alignGiftBonus, short contextModif)
        {
            this.@base = @base;
            this.additionnal = additionnal;
            this.objectsAndMountBonus = objectsAndMountBonus;
            this.alignGiftBonus = alignGiftBonus;
            this.contextModif = contextModif;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteVarShort(@base);
            writer.WriteVarShort(additionnal);
            writer.WriteVarShort(objectsAndMountBonus);
            writer.WriteVarShort(alignGiftBonus);
            writer.WriteVarShort(contextModif);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

@base = reader.ReadVarShort();
            additionnal = reader.ReadVarShort();
            objectsAndMountBonus = reader.ReadVarShort();
            alignGiftBonus = reader.ReadVarShort();
            contextModif = reader.ReadVarShort();
            

}


}


}