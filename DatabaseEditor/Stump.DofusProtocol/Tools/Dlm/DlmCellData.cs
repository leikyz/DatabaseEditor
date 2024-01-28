using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public struct DlmCellData
    {
        private short? m_floor;

        private sbyte m_rawFloor;

        public bool Blue
        {
            get { return (LosMov & 16) >> 4 == 1; }
        }

        public bool FarmCell
        {
            get { return (LosMov & 32) >> 5 == 1; }
        }

        public short Floor
        {
            get
            {
                short valueOrDefault;
                var mFloor = m_floor;
                if (mFloor.HasValue)
                {
                    valueOrDefault = mFloor.GetValueOrDefault();
                }
                else
                {
                    short? nullable = (short) (m_rawFloor*10);
                    var nullable1 = nullable;
                    m_floor = nullable;
                    valueOrDefault = nullable1.Value;
                }
                return valueOrDefault;
            }
        }

        public short Id { get; set; }

        public bool Los
        {
            get { return (LosMov & 2) >> 1 == 1; }
        }

        public byte LosMov { get; set; }

        public byte MapChangeData { get; set; }

        public bool Mov
        {
            get { return (LosMov & 1) != 1 || NonWalkableDuringFight ? false : !FarmCell; }
        }

        public byte MoveZone { get; set; }

        public bool NonWalkableDuringFight
        {
            get { return (LosMov & 4) >> 2 == 1; }
        }

        public bool Red
        {
            get { return (LosMov & 8) >> 3 == 1; }
        }

        public byte Speed { get; set; }

        public bool Visible
        {
            get { return (LosMov & 64) >> 6 == 1; }
        }

        public DlmCellData(short id)
        {
            Id = id;
            LosMov = 3;
            m_rawFloor = 0;
            m_floor = 0;
            Speed = 0;
            MapChangeData = 0;
            MoveZone = 0;
        }

        public static DlmCellData ReadFromStream(short id, byte version, IDataReader reader)
        {
            DlmCellData dlmCellDatum;
            var dlmCellDatum1 = new DlmCellData(id)
            {
                m_rawFloor = reader.ReadSByte()
            };
            if (dlmCellDatum1.m_rawFloor != -128)
            {
                dlmCellDatum1.LosMov = reader.ReadByte();
                dlmCellDatum1.Speed = reader.ReadByte();
                dlmCellDatum1.MapChangeData = reader.ReadByte();
                if (version > 5)
                {
                    dlmCellDatum1.MoveZone = reader.ReadByte();
                }
                dlmCellDatum = dlmCellDatum1;
            }
            else
            {
                dlmCellDatum = dlmCellDatum1;
            }
            return dlmCellDatum;
        }
    }
}