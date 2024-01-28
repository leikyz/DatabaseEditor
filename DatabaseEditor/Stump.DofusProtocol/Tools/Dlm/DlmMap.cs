using System;
using System.Drawing;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Classes;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmMap : IDataObject
    {
        public const uint Width = 14;

        public const uint Height = 20;

        public const int CellCount = 560;

        private static readonly Point[] s_orthogonalGridReference;

        private static bool m_initialized;

        static DlmMap()
        {
            s_orthogonalGridReference = new Point[560];
        }

        public DlmFixture[] BackgroudFixtures { get; set; }

        public Color BackgroundColor { get; set; }

        public int BottomNeighbourId { get; set; }

        public DlmCellData[] Cells { get; set; }

        public bool Encrypted { get; set; }

        public byte EncryptionVersion { get; set; }

        public DlmFixture[] ForegroundFixtures { get; set; }

        public int GroundCRC { get; set; }

        public int Id { get; set; }

        public DlmLayer[] Layers { get; set; }

        public int LeftNeighbourId { get; set; }

        public byte MapType { get; set; }

        public int PresetId { get; set; }

        public uint RelativeId { get; set; }

        public int RightNeighbourId { get; set; }

        public int ShadowBonusOnEntities { get; set; }

        public int SubAreaId { get; set; }

        public int TopNeighbourId { get; set; }

        public bool UseLowPassFilter { get; set; }

        public bool UseReverb { get; set; }

        public bool UsingNewMovementSystem { get; set; }

        public byte Version { get; set; }

        public short ZoomOffsetX { get; set; }

        public short ZoomOffsetY { get; set; }

        public ushort ZoomScale { get; set; }

        public static DlmMap ReadFromStream(IDataReader givenReader, DlmReader dlmReader)
        {
            int num2;
            var reader = givenReader;
            var map = new DlmMap
            {
                Version = reader.ReadByte(),
                Id = reader.ReadInt()
            };
            if (map.Version >= 7)
            {
                map.Encrypted = reader.ReadBoolean();
                map.EncryptionVersion = reader.ReadByte();
                var num = reader.ReadInt();
                if (map.Encrypted)
                {
                    var decryptionKey = dlmReader.DecryptionKey;
                    if ((decryptionKey == null) && (dlmReader.DecryptionKeyProvider != null))
                    {
                        decryptionKey = dlmReader.DecryptionKeyProvider(map.Id);
                    }
                    if (decryptionKey == null)
                    {
                        throw new InvalidOperationException(
                            string.Format("Cannot decrypt the map {0} without decryption key", map.Id));
                    }
                    var buffer = reader.ReadBytes(num);
                    var bytes = Encoding.Default.GetBytes(decryptionKey);
                    if (decryptionKey.Length > 0)
                    {
                        for (num2 = 0; num2 < buffer.Length; num2++)
                        {
                            buffer[num2] = (byte) (buffer[num2] ^ bytes[num2%decryptionKey.Length]);
                        }
                        reader = new FastBigEndianReader(buffer);
                    }
                }
            }
            map.RelativeId = reader.ReadUInt();
            map.MapType = reader.ReadByte();
            if ((map.MapType < 0) || (map.MapType > 1))
            {
                throw new Exception("Invalid decryption key");
            }
            map.SubAreaId = reader.ReadInt();
            map.TopNeighbourId = reader.ReadInt();
            map.BottomNeighbourId = reader.ReadInt();
            map.LeftNeighbourId = reader.ReadInt();
            map.RightNeighbourId = reader.ReadInt();
            map.ShadowBonusOnEntities = reader.ReadInt();
            if (map.Version >= 3)
            {
                map.BackgroundColor = Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
            }
            if (map.Version >= 4)
            {
                map.ZoomScale = reader.ReadUShort();
                map.ZoomOffsetX = reader.ReadShort();
                map.ZoomOffsetY = reader.ReadShort();
            }
            map.UseLowPassFilter = reader.ReadByte() == 1;
            map.UseReverb = reader.ReadByte() == 1;
            if (map.UseReverb)
            {
                map.PresetId = reader.ReadInt();
            }
            map.PresetId = -1;
            map.BackgroudFixtures = new DlmFixture[reader.ReadByte()];
            for (num2 = 0; num2 < map.BackgroudFixtures.Length; num2++)
            {
                map.BackgroudFixtures[num2] = DlmFixture.ReadFromStream(map, reader);
            }
            map.ForegroundFixtures = new DlmFixture[reader.ReadByte()];
            for (num2 = 0; num2 < map.ForegroundFixtures.Length; num2++)
            {
                map.ForegroundFixtures[num2] = DlmFixture.ReadFromStream(map, reader);
            }
            reader.ReadInt();
            map.GroundCRC = reader.ReadInt();
            map.Layers = new DlmLayer[reader.ReadByte()];
            for (num2 = 0; num2 < map.Layers.Length; num2++)
            {
                map.Layers[num2] = DlmLayer.ReadFromStream(map, reader);
            }
            map.Cells = new DlmCellData[560];
            int? nullable = null;
            for (short i = 0; i < map.Cells.Length; i = (short) (i + 1))
            {
                map.Cells[i] = DlmCellData.ReadFromStream(i, map.Version, reader);
                if (!nullable.HasValue)
                {
                    nullable = map.Cells[i].MoveZone;
                }
                else
                {
                    var nullable2 = nullable;
                    int moveZone = map.Cells[i].MoveZone;
                    if ((nullable2.GetValueOrDefault() != moveZone) || !nullable2.HasValue)
                    {
                        map.UsingNewMovementSystem = true;
                    }
                }
            }
            return map;
        }
    }
}