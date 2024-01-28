



















// Generated on 04/20/2016 12:03:12
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.DofusProtocol.Types;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{

public class ServerSettingsMessage : Message
{

public const ushort Id = 6340;
public override ushort MessageId
{
    get { return Id; }
}

public string lang;
        public sbyte community;
        public sbyte gameType;
        

public ServerSettingsMessage()
{
}

public ServerSettingsMessage(string lang, sbyte community, sbyte gameType)
        {
            this.lang = lang;
            this.community = community;
            this.gameType = gameType;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteUTF(lang);
            writer.WriteSByte(community);
            writer.WriteSByte(gameType);
            

}

public override void Deserialize(ICustomDataInput reader)
{

lang = reader.ReadUTF();
            community = reader.ReadSByte();
            if (community < 0)
                throw new Exception("Forbidden value on community = " + community + ", it doesn't respect the following condition : community < 0");
            gameType = reader.ReadSByte();
            

}


}


}