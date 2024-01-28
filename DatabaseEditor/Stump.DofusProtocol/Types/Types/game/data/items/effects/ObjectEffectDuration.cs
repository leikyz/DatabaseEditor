



















// Generated on 04/20/2016 12:44:16
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class ObjectEffectDuration : ObjectEffect
{

public const short Id = 75;
public override short TypeId
{
    get { return Id; }
}

public ushort days;
        public sbyte hours;
        public sbyte minutes;
        

public ObjectEffectDuration()
{
}

public ObjectEffectDuration(ushort actionId, ushort days, sbyte hours, sbyte minutes)
         : base(actionId)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhShort(days);
            writer.WriteByte((byte)hours);
            writer.WriteByte((byte)minutes);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            days = reader.ReadVarUhShort();
            if (days < 0)
                throw new Exception("Forbidden value on days = " + days + ", it doesn't respect the following condition : days < 0");
            hours = (sbyte)reader.ReadByte();
            if (hours < 0)
                throw new Exception("Forbidden value on hours = " + hours + ", it doesn't respect the following condition : hours < 0");
            minutes = (sbyte)reader.ReadByte();
            if (minutes < 0)
                throw new Exception("Forbidden value on minutes = " + minutes + ", it doesn't respect the following condition : minutes < 0");
            

}


}


}