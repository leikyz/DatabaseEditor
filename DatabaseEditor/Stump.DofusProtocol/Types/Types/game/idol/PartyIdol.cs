



















// Generated on 04/20/2016 12:44:17
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class PartyIdol : Idol
{

public const short Id = 490;
public override short TypeId
{
    get { return Id; }
}

public IEnumerable<ulong> ownersIds;
        

public PartyIdol()
{
}

public PartyIdol(ushort id, ushort xpBonusPercent, ushort dropBonusPercent, IEnumerable<ulong> ownersIds)
         : base(id, xpBonusPercent, dropBonusPercent)
        {
            this.ownersIds = ownersIds;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)ownersIds.Count());
            foreach (var entry in ownersIds)
            {
                 writer.WriteVarUhLong(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            ownersIds = new ulong[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ownersIds as ulong[])[i] = reader.ReadVarUhLong();
            }
            

}


}


}