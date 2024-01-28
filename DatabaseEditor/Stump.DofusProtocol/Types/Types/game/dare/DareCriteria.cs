



















// Generated on 04/20/2016 12:44:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class DareCriteria
{

public const short Id = 501;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        public IEnumerable<int> @params;
        

public DareCriteria()
{
}

public DareCriteria(sbyte type, IEnumerable<int> @params)
        {
            this.type = type;
            this.@params = @params;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(type);
            writer.WriteUShort((ushort)@params.Count());
            foreach (var entry in @params)
            {
                 writer.WriteInt(entry);
            }
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            var limit = reader.ReadUShort();
            @params = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 ( @params as int[])[i] = reader.ReadInt();
            }
            

}


}


}