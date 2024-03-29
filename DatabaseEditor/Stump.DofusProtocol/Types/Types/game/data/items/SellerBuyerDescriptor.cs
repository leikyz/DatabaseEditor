



















// Generated on 04/20/2016 12:44:15
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class SellerBuyerDescriptor
{

public const short Id = 121;
public virtual short TypeId
{
    get { return Id; }
}

public IEnumerable<uint> quantities;
        public IEnumerable<uint> types;
        public float taxPercentage;
        public float taxModificationPercentage;
        public byte maxItemLevel;
        public uint maxItemPerAccount;
        public int npcContextualId;
        public ushort unsoldDelay;
        

public SellerBuyerDescriptor()
{
}

public SellerBuyerDescriptor(IEnumerable<uint> quantities, IEnumerable<uint> types, float taxPercentage, float taxModificationPercentage, byte maxItemLevel, uint maxItemPerAccount, int npcContextualId, ushort unsoldDelay)
        {
            this.quantities = quantities;
            this.types = types;
            this.taxPercentage = taxPercentage;
            this.taxModificationPercentage = taxModificationPercentage;
            this.maxItemLevel = maxItemLevel;
            this.maxItemPerAccount = maxItemPerAccount;
            this.npcContextualId = npcContextualId;
            this.unsoldDelay = unsoldDelay;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)quantities.Count());
            foreach (var entry in quantities)
            {
                 writer.WriteVarUhInt(entry);
            }
            writer.WriteUShort((ushort)types.Count());
            foreach (var entry in types)
            {
                 writer.WriteVarUhInt(entry);
            }
            writer.WriteFloat(taxPercentage);
            writer.WriteFloat(taxModificationPercentage);
            writer.WriteByte(maxItemLevel);
            writer.WriteVarUhInt(maxItemPerAccount);
            writer.WriteInt(npcContextualId);
            writer.WriteVarUhShort(unsoldDelay);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            quantities = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (quantities as uint[])[i] = reader.ReadVarUhInt();
            }
            limit = reader.ReadUShort();
            types = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (types as uint[])[i] = reader.ReadVarUhInt();
            }
            taxPercentage = reader.ReadFloat();
            taxModificationPercentage = reader.ReadFloat();
            maxItemLevel = reader.ReadByte();
            if (maxItemLevel < 0 || maxItemLevel > 255)
                throw new Exception("Forbidden value on maxItemLevel = " + maxItemLevel + ", it doesn't respect the following condition : maxItemLevel < 0 || maxItemLevel > 255");
            maxItemPerAccount = reader.ReadVarUhInt();
            if (maxItemPerAccount < 0)
                throw new Exception("Forbidden value on maxItemPerAccount = " + maxItemPerAccount + ", it doesn't respect the following condition : maxItemPerAccount < 0");
            npcContextualId = reader.ReadInt();
            unsoldDelay = reader.ReadVarUhShort();
            if (unsoldDelay < 0)
                throw new Exception("Forbidden value on unsoldDelay = " + unsoldDelay + ", it doesn't respect the following condition : unsoldDelay < 0");
            

}


}


}