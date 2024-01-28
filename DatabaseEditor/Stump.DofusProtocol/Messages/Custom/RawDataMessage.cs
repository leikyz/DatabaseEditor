using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
    public class RawDataMessage : Message
    {
        public const ushort Id = 6253;
        public byte[] Content;

        public RawDataMessage()
        {
        }

        public RawDataMessage(byte[] content)
        {
            Content = content;
        }

        public override ushort MessageId => 6253;

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarInt(Content.Length);
            writer.WriteBytes(Content);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            var n = reader.ReadShort();
            Content = reader.ReadBytes(n);
        }
    }
}