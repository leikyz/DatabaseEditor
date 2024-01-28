// Generated on 06/05/2015 03:00:12

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlignmentRankJntGift", "com.ankamagames.dofus.datacenter.alignments", true)]
    public class AlignmentRankJntGift : IDataObject, IIndexedData
    {
        public const string MODULE = "AlignmentRankJntGift";

        public List<int> gifts;
        public int id;

        public List<int> levels;

        public List<int> parameters;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public List<int> Gifts
        {
            get { return gifts; }

            set { gifts = value; }
        }

        [D2OIgnore]
        public List<int> Parameters
        {
            get { return parameters; }

            set { parameters = value; }
        }

        [D2OIgnore]
        public List<int> Levels
        {
            get { return levels; }

            set { levels = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}