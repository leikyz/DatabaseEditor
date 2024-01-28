



















// Generated on 04/20/2016 12:04:08
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ExchangeGuildTaxCollectorGetMessage : Message
{

public const ushort Id = 5762;
public override ushort MessageId
{
    get { return Id; }
}

public string collectorName;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public string userName;
        public ulong callerId;
        public string callerName;
        public double experience;
        public ushort pods;
        public IEnumerable<ObjectItemGenericQuantity> objectsInfos;
        

public ExchangeGuildTaxCollectorGetMessage()
{
}

public ExchangeGuildTaxCollectorGetMessage(string collectorName, short worldX, short worldY, int mapId, ushort subAreaId, string userName, ulong callerId, string callerName, double experience, ushort pods, IEnumerable<ObjectItemGenericQuantity> objectsInfos)
        {
            this.collectorName = collectorName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.userName = userName;
            this.callerId = callerId;
            this.callerName = callerName;
            this.experience = experience;
            this.pods = pods;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(collectorName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarUhShort(subAreaId);
            writer.WriteUTF(userName);
            writer.WriteVarUhLong(callerId);
            writer.WriteUTF(callerName);
            writer.WriteDouble(experience);
            writer.WriteVarUhShort(pods);
            writer.WriteUShort((ushort)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

collectorName = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            userName = reader.ReadUTF();
            callerId = reader.ReadVarUhLong();
            if (callerId < 0 || callerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on callerId = " + callerId + ", it doesn't respect the following condition : callerId < 0 || callerId > 9.007199254740992E15");
            callerName = reader.ReadUTF();
            experience = reader.ReadDouble();
            if (experience < -9.007199254740992E15 || experience > 9.007199254740992E15)
                throw new Exception("Forbidden value on experience = " + experience + ", it doesn't respect the following condition : experience < -9.007199254740992E15 || experience > 9.007199254740992E15");
            pods = reader.ReadVarUhShort();
            if (pods < 0)
                throw new Exception("Forbidden value on pods = " + pods + ", it doesn't respect the following condition : pods < 0");
            var limit = reader.ReadUShort();
            objectsInfos = new ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                var _loc4_ = new ObjectItemGenericQuantity();
                _loc4_.Deserialize(reader);
                (objectsInfos as ObjectItemGenericQuantity[])[i] = _loc4_;
            }
            

}


}


}