



















// Generated on 04/20/2016 12:03:58
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class GuildInformationsPaddocksMessage : Message
{

public const ushort Id = 5959;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte nbPaddockMax;
        public IEnumerable<PaddockContentInformations> paddocksInformations;
        

public GuildInformationsPaddocksMessage()
{
}

public GuildInformationsPaddocksMessage(sbyte nbPaddockMax, IEnumerable<PaddockContentInformations> paddocksInformations)
        {
            this.nbPaddockMax = nbPaddockMax;
            this.paddocksInformations = paddocksInformations;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(nbPaddockMax);
            writer.WriteUShort((ushort)paddocksInformations.Count());
            foreach (var entry in paddocksInformations)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

nbPaddockMax = reader.ReadSByte();
            if (nbPaddockMax < 0)
                throw new Exception("Forbidden value on nbPaddockMax = " + nbPaddockMax + ", it doesn't respect the following condition : nbPaddockMax < 0");
            var limit = reader.ReadUShort();
            paddocksInformations = new PaddockContentInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddocksInformations as PaddockContentInformations[])[i].Deserialize(reader);
            }
            

}


}


}