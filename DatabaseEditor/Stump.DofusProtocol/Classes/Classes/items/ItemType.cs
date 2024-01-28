// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ItemTypes", "com.ankamagames.dofus.datacenter.items", true)]
    public class ItemType : IDataObject, IIndexedData
    {
        public const string MODULE = "ItemTypes";

        public int craftXpRatio;

        public uint gender;
        public int id;

        public bool mimickable;

        public uint nameId;

        public bool plural;

        public string rawZone;

        public uint superTypeId;

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
        public uint SuperTypeId
        {
            get { return superTypeId; }

            set { superTypeId = value; }
        }

        [D2OIgnore]
        public bool Plural
        {
            get { return plural; }

            set { plural = value; }
        }

        [D2OIgnore]
        public uint Gender
        {
            get { return gender; }

            set { gender = value; }
        }

        [D2OIgnore]
        public string RawZone
        {
            get { return rawZone; }

            set { rawZone = value; }
        }

        [D2OIgnore]
        public bool Mimickable
        {
            get { return mimickable; }

            set { mimickable = value; }
        }

        [D2OIgnore]
        public int CraftXpRatio
        {
            get { return craftXpRatio; }

            set { craftXpRatio = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}