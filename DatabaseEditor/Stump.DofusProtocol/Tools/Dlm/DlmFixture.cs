using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmFixture
    {
        public DlmFixture(DlmMap map)
        {
            Map = map;
        }

        public byte Alpha { get; set; }

        public int FixtureId { get; private set; }

        public int Hue { get; set; }

        public DlmMap Map { get; set; }

        public System.Drawing.Point Offset { get; set; }

        public short Rotation { get; set; }

        public short ScaleX { get; set; }

        public short ScaleY { get; set; }

        public static DlmFixture ReadFromStream(DlmMap map, IDataReader reader)
        {
            var dlmFixture = new DlmFixture(map)
            {
                FixtureId = reader.ReadInt(),
                Offset = new System.Drawing.Point(reader.ReadShort(), reader.ReadShort()),
                Rotation = reader.ReadShort(),
                ScaleX = reader.ReadShort(),
                ScaleY = reader.ReadShort(),
                Hue = reader.ReadByte() << 16 | reader.ReadByte() << 8 | reader.ReadByte(),
                Alpha = reader.ReadByte()
            };
            return dlmFixture;
        }
    }
}