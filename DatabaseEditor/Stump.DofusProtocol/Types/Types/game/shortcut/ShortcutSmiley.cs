



















// Generated on 04/20/2016 12:44:20
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class ShortcutSmiley : Shortcut
{

public const short Id = 388;
public override short TypeId
{
    get { return Id; }
}

public ushort smileyId;
        

public ShortcutSmiley()
{
}

public ShortcutSmiley(sbyte slot, ushort smileyId)
         : base(slot)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(smileyId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            smileyId = reader.ReadVarUhShort();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}