// Generated on 06/05/2015 03:00:22

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SoundBones", "com.ankamagames.dofus.datacenter.sounds", true)]
    public class SoundBones : IDataObject, IIndexedData
    {
        public int id;

        public List<string> keys;
        public string MODULE = "SoundBones";

        public List<List<SoundAnimation>> values;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public List<string> Keys
        {
            get { return keys; }

            set { keys = value; }
        }

        [D2OIgnore]
        public List<List<SoundAnimation>> Values
        {
            get { return values; }

            set { values = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}