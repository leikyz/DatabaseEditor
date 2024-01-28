// Generated on 06/05/2015 03:00:22

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SoundUi", "com.ankamagames.dofus.datacenter.sounds", true)]
    public class SoundUi : IDataObject, IIndexedData
    {
        public string closeFile;
        public int id;
        public string MODULE = "SoundUi";

        public string openFile;

        public List<SoundUiElement> subElements;

        public string uiName;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public string UiName
        {
            get { return uiName; }

            set { uiName = value; }
        }

        [D2OIgnore]
        public string OpenFile
        {
            get { return openFile; }

            set { openFile = value; }
        }

        [D2OIgnore]
        public string CloseFile
        {
            get { return closeFile; }

            set { closeFile = value; }
        }

        [D2OIgnore]
        public List<SoundUiElement> SubElements
        {
            get { return subElements; }

            set { subElements = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}