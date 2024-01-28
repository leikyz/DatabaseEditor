// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Titles", "com.ankamagames.dofus.datacenter.appearance", true)]
    public class Title : IDataObject, IIndexedData
    {
        public const string MODULE = "Titles";

        public int categoryId;
        public int id;

        public uint nameFemaleId;

        public uint nameMaleId;

        public bool visible;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint NameMaleId
        {
            get { return nameMaleId; }

            set { nameMaleId = value; }
        }

        [D2OIgnore]
        public uint NameFemaleId
        {
            get { return nameFemaleId; }

            set { nameFemaleId = value; }
        }

        [D2OIgnore]
        public bool Visible
        {
            get { return visible; }

            set { visible = value; }
        }

        [D2OIgnore]
        public int CategoryId
        {
            get { return categoryId; }

            set { categoryId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}