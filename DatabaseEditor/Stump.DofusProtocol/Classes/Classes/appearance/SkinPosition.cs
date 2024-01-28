// Generated on 06/05/2015 03:00:12

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SkinPositions", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class SkinPosition : IDataObject, IIndexedData
    {
        private const string MODULE = "SkinPositions";

        public List<string> clip;
        public int id;

        public List<uint> skin;

        public List<TransformData> transformation;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public List<TransformData> Transformation
        {
            get { return transformation; }

            set { transformation = value; }
        }

        [D2OIgnore]
        public List<string> Clip
        {
            get { return clip; }

            set { clip = value; }
        }

        [D2OIgnore]
        public List<uint> Skin
        {
            get { return skin; }

            set { skin = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}