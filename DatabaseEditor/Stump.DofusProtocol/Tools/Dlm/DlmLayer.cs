using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmLayer
    {
        public DlmLayer(DlmMap map)
        {
            Map = map;
        }

        public DlmCell[] Cells { get; set; }

        public int LayerId { get; set; }

        public DlmMap Map { get; set; }

        public static DlmLayer ReadFromStream(DlmMap map, IDataReader reader)
        {
            var dlmLayer = new DlmLayer(map)
            {
                LayerId = reader.ReadInt(),
                Cells = new DlmCell[reader.ReadShort()]
            };
            for (var i = 0; i < dlmLayer.Cells.Length; i++)
            {
                dlmLayer.Cells[i] = DlmCell.ReadFromStream(dlmLayer, reader);
            }
            return dlmLayer;
        }
    }
}