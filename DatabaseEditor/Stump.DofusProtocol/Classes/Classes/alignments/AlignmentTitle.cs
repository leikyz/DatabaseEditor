// Generated on 06/05/2015 03:00:12

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentTitles", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentTitle : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentTitles";

        public List<int> namesId;

        public List<int> shortsId;
        public int sideId;

        [D2OIgnore]
        public int SideId
        {
            get { return sideId; }

            set { sideId = value; }
        }

        [D2OIgnore]
        public List<int> NamesId
        {
            get { return namesId; }

            set { namesId = value; }
        }

        [D2OIgnore]
        public List<int> ShortsId
        {
            get { return shortsId; }

            set { shortsId = value; }
        }

        int IIndexedData.Id
        {
            get { return sideId; }
        }
    }
}