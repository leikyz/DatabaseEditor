



















// Generated on 04/20/2016 12:03:23
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ShowCellSpectatorMessage : ShowCellMessage
{

public const ushort Id = 6158;
public override ushort MessageId
{
    get { return Id; }
}

public string playerName;
        

public ShowCellSpectatorMessage()
{
}

public ShowCellSpectatorMessage(double sourceId, ushort cellId, string playerName)
         : base(sourceId, cellId)
        {
            this.playerName = playerName;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            playerName = reader.ReadUTF();
            

}


}


}