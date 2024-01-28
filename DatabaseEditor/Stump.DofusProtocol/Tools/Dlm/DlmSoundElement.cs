using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmSoundElement : DlmBasicElement
    {
        public DlmSoundElement(DlmCell cell) : base(cell)
        {
        }

        public int BaseVolume { get; set; }

        public int FullVolumedistance { get; set; }

        public int MaxDelayBetweenloops { get; set; }

        public int MinDelayBetweenloops { get; set; }

        public int NullVolumedistance { get; set; }

        public int SoundId { get; set; }

        public new static DlmSoundElement ReadFromStream(DlmCell cell, IDataReader reader)
        {
            var dlmSoundElement = new DlmSoundElement(cell)
            {
                SoundId = reader.ReadInt(),
                BaseVolume = reader.ReadShort(),
                FullVolumedistance = reader.ReadInt(),
                NullVolumedistance = reader.ReadInt(),
                MinDelayBetweenloops = reader.ReadShort(),
                MaxDelayBetweenloops = reader.ReadShort()
            };
            return dlmSoundElement;
        }
    }
}