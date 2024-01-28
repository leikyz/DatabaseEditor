using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmCell
    {
        public DlmCell(DlmLayer layer)
        {
            Layer = layer;
        }

        public DlmBasicElement[] Elements { get; set; }

        public short Id { get; set; }

        public DlmLayer Layer { get; set; }

        public static DlmCell ReadFromStream(DlmLayer layer, IDataReader reader)
        {
            var dlmCell = new DlmCell(layer)
            {
                Id = reader.ReadShort(),
                Elements = new DlmBasicElement[reader.ReadShort()]
            };
            for (var i = 0; i < dlmCell.Elements.Length; i++)
            {
                var dlmBasicElement = DlmBasicElement.ReadFromStream(dlmCell, reader);
                dlmCell.Elements[i] = dlmBasicElement;
            }
            return dlmCell;
        }
    }
}