// Generated on 06/05/2015 03:00:13

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CharacteristicCategories", "com.ankamagames.dofus.datacenter.characteristics", true)]
    public class CharacteristicCategory : IDataObject, IIndexedData
    {
        public const string MODULE = "CharacteristicCategories";

        public List<uint> characteristicIds;
        public int id;

        public uint nameId;

        public int order;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public int Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public List<uint> CharacteristicIds
        {
            get { return characteristicIds; }

            set { characteristicIds = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}