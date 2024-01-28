



















// Generated on 04/20/2016 12:03:53
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class DareWonListMessage : Message
{

public const ushort Id = 6682;
public override ushort MessageId
{
    get { return Id; }
}

public IEnumerable<double> dareId;
        

public DareWonListMessage()
{
}

public DareWonListMessage(IEnumerable<double> dareId)
        {
            this.dareId = dareId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUShort((ushort)dareId.Count());
            foreach (var entry in dareId)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

var limit = reader.ReadUShort();
            dareId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dareId as double[])[i] = reader.ReadDouble();
            }
            

}


}


}