// Generated on 06/05/2015 03:00:13

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Documents", "com.ankamagames.dofus.datacenter.documents", true)]
    public class Document : IDataObject, IIndexedData
    {
        private const string MODULE = "Documents";

        public uint authorId;

        public string clientProperties;

        public string contentCSS;

        public uint contentId;
        public int id;

        public bool showBackgroundImage;

        public bool showTitle;

        public uint subTitleId;

        public uint titleId;

        public uint typeId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public bool ShowTitle
        {
            get { return showTitle; }

            set { showTitle = value; }
        }

        [D2OIgnore]
        public bool ShowBackgroundImage
        {
            get { return showBackgroundImage; }

            set { showBackgroundImage = value; }
        }

        [D2OIgnore]
        public uint TitleId
        {
            get { return titleId; }

            set { titleId = value; }
        }

        [D2OIgnore]
        public uint AuthorId
        {
            get { return authorId; }

            set { authorId = value; }
        }

        [D2OIgnore]
        public uint SubTitleId
        {
            get { return subTitleId; }

            set { subTitleId = value; }
        }

        [D2OIgnore]
        public uint ContentId
        {
            get { return contentId; }

            set { contentId = value; }
        }

        [D2OIgnore]
        public string ContentCSS
        {
            get { return contentCSS; }

            set { contentCSS = value; }
        }

        [D2OIgnore]
        public string ClientProperties
        {
            get { return clientProperties; }

            set { clientProperties = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}