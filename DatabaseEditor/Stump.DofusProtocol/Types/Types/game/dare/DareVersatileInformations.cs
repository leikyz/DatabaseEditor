



















// Generated on 04/20/2016 12:44:14
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{

public class DareVersatileInformations
{

public const short Id = 504;
public virtual short TypeId
{
    get { return Id; }
}

public double dareId;
        public int countEntrants;
        public int countWinners;
        

public DareVersatileInformations()
{
}

public DareVersatileInformations(double dareId, int countEntrants, int countWinners)
        {
            this.dareId = dareId;
            this.countEntrants = countEntrants;
            this.countWinners = countWinners;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteDouble(dareId);
            writer.WriteInt(countEntrants);
            writer.WriteInt(countWinners);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

dareId = reader.ReadDouble();
            if (dareId < 0 || dareId > 9.007199254740992E15)
                throw new Exception("Forbidden value on dareId = " + dareId + ", it doesn't respect the following condition : dareId < 0 || dareId > 9.007199254740992E15");
            countEntrants = reader.ReadInt();
            if (countEntrants < 0)
                throw new Exception("Forbidden value on countEntrants = " + countEntrants + ", it doesn't respect the following condition : countEntrants < 0");
            countWinners = reader.ReadInt();
            if (countWinners < 0)
                throw new Exception("Forbidden value on countWinners = " + countWinners + ", it doesn't respect the following condition : countWinners < 0");
            

}


}


}