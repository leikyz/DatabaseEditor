



















// Generated on 04/20/2016 12:44:04
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class ServerSessionConstant
{

public const short Id = 430;
public virtual short TypeId
{
    get { return Id; }
}

public ushort id;
        

public ServerSessionConstant()
{
}

public ServerSessionConstant(ushort id)
        {
            this.id = id;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(id);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

id = reader.ReadVarUhShort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}