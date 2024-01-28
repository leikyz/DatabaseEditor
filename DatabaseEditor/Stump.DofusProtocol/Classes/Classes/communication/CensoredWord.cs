// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CensoredWords", "com.ankamagames.dofus.datacenter.communication", true)]
    public class CensoredWord : IDataObject, IIndexedData
    {
        public const string MODULE = "CensoredWords";

        public bool deepLooking;
        public int id;

        public string language;

        public uint listId;

        public string word;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint ListId
        {
            get { return listId; }

            set { listId = value; }
        }

        [D2OIgnore]
        public string Language
        {
            get { return language; }

            set { language = value; }
        }

        [D2OIgnore]
        public string Word
        {
            get { return word; }

            set { word = value; }
        }

        [D2OIgnore]
        public bool DeepLooking
        {
            get { return deepLooking; }

            set { deepLooking = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}