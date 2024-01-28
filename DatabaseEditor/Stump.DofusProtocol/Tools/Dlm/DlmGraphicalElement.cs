using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmGraphicalElement : DlmBasicElement
    {
        public const float CELL_HALF_WIDTH = 43f;

        public const float CELL_HALF_HEIGHT = 21.5f;

        private System.Drawing.Point m_offset;

        private System.Drawing.Point m_pixelOffset;

        public DlmGraphicalElement(DlmCell cell) : base(cell)
        {
        }

        public int Altitude { get; set; }

        public ColorMultiplicator ColorMultiplicator { get; private set; }

        public uint ElementId { get; set; }

        public ElementTypesEnum ElementType
        {
            get { return ElementTypesEnum.Graphical; }
        }

        public ColorMultiplicator FinalTeint
        {
            get { return ColorMultiplicator; }
            set { ColorMultiplicator = value; }
        }

        public ColorMultiplicator Hue { get; set; }

        public uint Identifier { get; set; }

        public System.Drawing.Point Offset
        {
            get { return m_offset; }
            set { m_offset = value; }
        }

        public System.Drawing.Point PixelOffset
        {
            get { return m_pixelOffset; }
            set { m_pixelOffset = value; }
        }

        public ColorMultiplicator Shadow { get; set; }

        public void CalculateFinalTeint()
        {
            var red = Hue.Red + Shadow.Red;
            var green = Hue.Green + Shadow.Green;
            var blue = Hue.Blue + Shadow.Blue;
            red = ColorMultiplicator.Clamp((red + 128) * 2, 0, 512);
            green = ColorMultiplicator.Clamp((green + 128) * 2, 0, 512);
            blue = ColorMultiplicator.Clamp((blue + 128) * 2, 0, 512);
            ColorMultiplicator = new ColorMultiplicator(red, green, blue, true);
        }

        public new static DlmGraphicalElement ReadFromStream(DlmCell cell, IDataReader reader)
        {
            var dlmGraphicalElement = new DlmGraphicalElement(cell)
            {
                ElementId = reader.ReadUInt(),
                Hue = new ColorMultiplicator(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), false),
                Shadow = new ColorMultiplicator(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), false)
            };
            if (cell.Layer.Map.Version > 4)
            {
                dlmGraphicalElement.m_pixelOffset.X = reader.ReadShort();
                dlmGraphicalElement.m_pixelOffset.Y = reader.ReadShort();
                dlmGraphicalElement.m_offset.X = (int)(dlmGraphicalElement.m_pixelOffset.X / 43f);
                dlmGraphicalElement.m_offset.Y = (int)(dlmGraphicalElement.m_pixelOffset.Y / 21.5f);
            }
            else
            {
                dlmGraphicalElement.m_offset.X = reader.ReadByte();
                dlmGraphicalElement.m_offset.Y = reader.ReadByte();
                dlmGraphicalElement.m_pixelOffset.X = (int)(dlmGraphicalElement.m_offset.X * 43f);
                dlmGraphicalElement.m_pixelOffset.Y = (int)(dlmGraphicalElement.m_offset.Y * 21.5f);
            }
            dlmGraphicalElement.Altitude = reader.ReadByte();
            dlmGraphicalElement.Identifier = reader.ReadUInt();
            return dlmGraphicalElement;
        }
    }
}