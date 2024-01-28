// Generated on 06/05/2015 03:00:18

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("SpeakingItemsTriggers", "com.ankamagames.dofus.datacenter.livingObjects", true)]
    public class SpeakingItemsTrigger : IDataObject, IIndexedData
    {
        public const string MODULE = "SpeakingItemsTriggers";

        public List<int> states;

        public List<int> textIds;
        public int triggersId;

        [D2OIgnore]
        public int TriggersId
        {
            get { return triggersId; }

            set { triggersId = value; }
        }

        [D2OIgnore]
        public List<int> TextIds
        {
            get { return textIds; }

            set { textIds = value; }
        }

        [D2OIgnore]
        public List<int> States
        {
            get { return states; }

            set { states = value; }
        }

        int IIndexedData.Id
        {
            get { return triggersId; }
        }
    }
}