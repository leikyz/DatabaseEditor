



















// Generated on 04/20/2016 12:03:42
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class EntityTalkMessage : Message
{

public const ushort Id = 6110;
public override ushort MessageId
{
    get { return Id; }
}

public double entityId;
        public ushort textId;
        public IEnumerable<string> parameters;
        

public EntityTalkMessage()
{
}

public EntityTalkMessage(double entityId, ushort textId, IEnumerable<string> parameters)
        {
            this.entityId = entityId;
            this.textId = textId;
            this.parameters = parameters;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarUhShort(textId);
            writer.WriteUShort((ushort)parameters.Count());
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

entityId = reader.ReadDouble();
            if (entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15)
                throw new Exception("Forbidden value on entityId = " + entityId + ", it doesn't respect the following condition : entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15");
            textId = reader.ReadVarUhShort();
            if (textId < 0)
                throw new Exception("Forbidden value on textId = " + textId + ", it doesn't respect the following condition : textId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (parameters as string[])[i] = reader.ReadUTF();
            }
            

}


}


}