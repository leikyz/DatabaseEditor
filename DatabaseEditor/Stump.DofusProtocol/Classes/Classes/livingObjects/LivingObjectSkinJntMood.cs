// Generated on 06/05/2015 03:00:18

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("LivingObjectSkinJntMood", "com.ankamagames.dofus.datacenter.livingObjects", true)]
    public class LivingObjectSkinJntMood : IDataObject, IIndexedData
    {
        public const string MODULE = "LivingObjectSkinJntMood";

        public List<List<int>> moods;
        public int skinId;

        [D2OIgnore]
        public int SkinId
        {
            get { return skinId; }

            set { skinId = value; }
        }

        [D2OIgnore]
        public List<List<int>> Moods
        {
            get { return moods; }

            set { moods = value; }
        }

        int IIndexedData.Id
        {
            get { return skinId; }
        }
    }
}