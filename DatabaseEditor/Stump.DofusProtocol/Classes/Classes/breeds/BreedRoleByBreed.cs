// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("BreedRoleByBreeds", "com.ankamagames.dofus.datacenter.breeds", true)]
    public class BreedRoleByBreed : IDataObject, IIndexedData
    {
        public const string MODULE = "BreedRoleByBreeds";
        public int breedId;

        public uint descriptionId;

        public int order;

        public int roleId;

        public int value;

        [D2OIgnore]
        public int BreedId
        {
            get { return breedId; }

            set { breedId = value; }
        }

        [D2OIgnore]
        public int RoleId
        {
            get { return roleId; }

            set { roleId = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public int Value
        {
            get { return value; }

            set { value = value; }
        }

        [D2OIgnore]
        public int Order
        {
            get { return order; }

            set { order = value; }
        }

        int IIndexedData.Id
        {
            get { return breedId; }
        }
    }
}