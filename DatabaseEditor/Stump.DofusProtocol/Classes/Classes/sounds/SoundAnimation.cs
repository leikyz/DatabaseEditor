// Generated on 06/05/2015 03:00:22

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SoundAnimations", "com.ankamagames.dofus.datacenter.sounds", true)]
    public class SoundAnimation : IDataObject, IIndexedData
    {
        public int automationDuration;

        public int automationFadeIn;

        public int automationFadeOut;

        public int automationVolume;

        public string filename;
        public int id;

        public string label;
        public string MODULE = "SoundAnimations";

        public string name;

        public bool noCutSilence;

        public int rolloff;

        public uint startFrame;

        public int volume;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        [D2OIgnore]
        public string Label
        {
            get { return label; }

            set { label = value; }
        }

        [D2OIgnore]
        public string Filename
        {
            get { return filename; }

            set { filename = value; }
        }

        [D2OIgnore]
        public int Volume
        {
            get { return volume; }

            set { volume = value; }
        }

        [D2OIgnore]
        public int Rolloff
        {
            get { return rolloff; }

            set { rolloff = value; }
        }

        [D2OIgnore]
        public int AutomationDuration
        {
            get { return automationDuration; }

            set { automationDuration = value; }
        }

        [D2OIgnore]
        public int AutomationVolume
        {
            get { return automationVolume; }

            set { automationVolume = value; }
        }

        [D2OIgnore]
        public int AutomationFadeIn
        {
            get { return automationFadeIn; }

            set { automationFadeIn = value; }
        }

        [D2OIgnore]
        public int AutomationFadeOut
        {
            get { return automationFadeOut; }

            set { automationFadeOut = value; }
        }

        [D2OIgnore]
        public bool NoCutSilence
        {
            get { return noCutSilence; }

            set { noCutSilence = value; }
        }

        [D2OIgnore]
        public uint StartFrame
        {
            get { return startFrame; }

            set { startFrame = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}