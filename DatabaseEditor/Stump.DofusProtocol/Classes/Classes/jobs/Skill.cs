// Generated on 06/05/2015 03:00:18

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Skills", "com.ankamagames.dofus.datacenter.jobs", true)]
    public class Skill : IDataObject, IIndexedData
    {
        public const string MODULE = "Skills";

        public bool availableInHouse;

        public bool clientDisplay;

        public List<int> craftableItemIds;

        public int cursor;

        public int elementActionId;

        public int gatheredRessourceItem;
        public int id;

        public int interactiveId;

        public bool isForgemagus;

        public bool isRepair;

        public uint levelMin;

        public List<int> modifiableItemTypeIds;

        public uint nameId;

        public int parentJobId;

        public string useAnimation;

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
        public int ParentJobId
        {
            get { return parentJobId; }

            set { parentJobId = value; }
        }

        [D2OIgnore]
        public bool IsForgemagus
        {
            get { return isForgemagus; }

            set { isForgemagus = value; }
        }

        [D2OIgnore]
        public List<int> ModifiableItemTypeIds
        {
            get { return modifiableItemTypeIds; }

            set { modifiableItemTypeIds = value; }
        }

        [D2OIgnore]
        public int GatheredRessourceItem
        {
            get { return gatheredRessourceItem; }

            set { gatheredRessourceItem = value; }
        }

        [D2OIgnore]
        public List<int> CraftableItemIds
        {
            get { return craftableItemIds; }

            set { craftableItemIds = value; }
        }

        [D2OIgnore]
        public int InteractiveId
        {
            get { return interactiveId; }

            set { interactiveId = value; }
        }

        [D2OIgnore]
        public string UseAnimation
        {
            get { return useAnimation; }

            set { useAnimation = value; }
        }

        [D2OIgnore]
        public bool IsRepair
        {
            get { return isRepair; }

            set { isRepair = value; }
        }

        [D2OIgnore]
        public int Cursor
        {
            get { return cursor; }

            set { cursor = value; }
        }

        [D2OIgnore]
        public int ElementActionId
        {
            get { return elementActionId; }

            set { elementActionId = value; }
        }

        [D2OIgnore]
        public bool AvailableInHouse
        {
            get { return availableInHouse; }

            set { availableInHouse = value; }
        }

        [D2OIgnore]
        public uint LevelMin
        {
            get { return levelMin; }

            set { levelMin = value; }
        }

        [D2OIgnore]
        public bool ClientDisplay
        {
            get { return clientDisplay; }

            set { clientDisplay = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}