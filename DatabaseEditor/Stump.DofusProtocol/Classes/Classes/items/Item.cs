// Generated on 06/05/2015 03:00:15

using System.Collections.Generic;
using Stump.DofusProtocol.D2oClasses;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Items", "com.ankamagames.dofus.datacenter.items", true)]
    public class Item : IDataObject, IIndexedData
    {
        public const string MODULE = "Items";
        public const uint EQUIPEMENT_CATEGORY = 0;
        public const uint CONSUMABLES_CATEGORY = 1;
        public const uint RESSOURCES_CATEGORY = 2;
        public const uint QUEST_CATEGORY = 3;
        public const uint OTHER_CATEGORY = 4;
        public const int MAX_JOB_LEVEL_GAP = 100;

        public uint appearanceId;

        public bool bonusIsSecret;

        public int craftXpRatio;

        public string criteria;

        public string criteriaTarget;

        public bool cursed;

        public uint descriptionId;

        public List<uint> dropMonsterIds;

        public bool enhanceable;

        public bool etheral;

        public bool exchangeable;

        public List<uint> favoriteSubAreas;

        public uint favoriteSubAreasBonus;

        public bool hideEffects;

        public int iconId;
        public int id;

        public int itemSetId;

        public uint level;

        public uint nameId;

        public bool needUseConfirm;

        public bool nonUsableOnAnother;

        public List<EffectInstance> possibleEffects;

        public float price;

        public uint realWeight;

        public List<uint> recipeIds;

        public uint recipeSlots;

        public bool secretRecipe;

        public bool targetable;

        public bool twoHanded;

        public ItemType type;

        public uint typeId;

        public bool usable;

        public int useAnimationId;

        public uint weight;

        public List<uint> containerIds;

        public List<List<double>> nuggetsBySubarea;

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
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public uint Level
        {
            get { return level; }

            set { level = value; }
        }

        [D2OIgnore]
        public uint RealWeight
        {
            get { return realWeight; }

            set { realWeight = value; }
        }

        [D2OIgnore]
        public bool Cursed
        {
            get { return cursed; }

            set { cursed = value; }
        }

        [D2OIgnore]
        public int UseAnimationId
        {
            get { return useAnimationId; }

            set { useAnimationId = value; }
        }

        [D2OIgnore]
        public bool Usable
        {
            get { return usable; }

            set { usable = value; }
        }

        [D2OIgnore]
        public bool Targetable
        {
            get { return targetable; }

            set { targetable = value; }
        }

        [D2OIgnore]
        public bool Exchangeable
        {
            get { return exchangeable; }

            set { exchangeable = value; }
        }

        [D2OIgnore]
        public float Price
        {
            get { return price; }

            set { price = value; }
        }

        [D2OIgnore]
        public bool TwoHanded
        {
            get { return twoHanded; }

            set { twoHanded = value; }
        }

        [D2OIgnore]
        public bool Etheral
        {
            get { return etheral; }

            set { etheral = value; }
        }

        [D2OIgnore]
        public int ItemSetId
        {
            get { return itemSetId; }

            set { itemSetId = value; }
        }

        [D2OIgnore]
        public string Criteria
        {
            get { return criteria; }

            set { criteria = value; }
        }

        [D2OIgnore]
        public string CriteriaTarget
        {
            get { return criteriaTarget; }

            set { criteriaTarget = value; }
        }

        [D2OIgnore]
        public bool HideEffects
        {
            get { return hideEffects; }

            set { hideEffects = value; }
        }

        [D2OIgnore]
        public bool Enhanceable
        {
            get { return enhanceable; }

            set { enhanceable = value; }
        }

        [D2OIgnore]
        public bool NonUsableOnAnother
        {
            get { return nonUsableOnAnother; }

            set { nonUsableOnAnother = value; }
        }

        [D2OIgnore]
        public uint AppearanceId
        {
            get { return appearanceId; }

            set { appearanceId = value; }
        }

        [D2OIgnore]
        public bool SecretRecipe
        {
            get { return secretRecipe; }

            set { secretRecipe = value; }
        }

        [D2OIgnore]
        public List<uint> DropMonsterIds
        {
            get { return dropMonsterIds; }

            set { dropMonsterIds = value; }
        }

        [D2OIgnore]
        public uint RecipeSlots
        {
            get { return recipeSlots; }

            set { recipeSlots = value; }
        }

        [D2OIgnore]
        public List<uint> RecipeIds
        {
            get { return recipeIds; }

            set { recipeIds = value; }
        }

        [D2OIgnore]
        public bool BonusIsSecret
        {
            get { return bonusIsSecret; }

            set { bonusIsSecret = value; }
        }

        [D2OIgnore]
        public List<EffectInstance> PossibleEffects
        {
            get { return possibleEffects; }

            set { possibleEffects = value; }
        }

        [D2OIgnore]
        public List<uint> FavoriteSubAreas
        {
            get { return favoriteSubAreas; }

            set { favoriteSubAreas = value; }
        }

        [D2OIgnore]
        public uint FavoriteSubAreasBonus
        {
            get { return favoriteSubAreasBonus; }

            set { favoriteSubAreasBonus = value; }
        }

        [D2OIgnore]
        public int CraftXpRatio
        {
            get { return craftXpRatio; }

            set { craftXpRatio = value; }
        }

        [D2OIgnore]
        public bool NeedUseConfirm
        {
            get { return needUseConfirm; }

            set { needUseConfirm = value; }
        }

        [D2OIgnore]
        public ItemType Type
        {
            get { return type; }

            set { type = value; }
        }

        [D2OIgnore]
        public uint Weight
        {
            get { return weight; }

            set { weight = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }

        [D2OIgnore]
        public List<uint> ContainerIds
        {
            get
            {
                return containerIds;
            }

            set
            {
                containerIds = value;
            }
        }

        public List<List<double>> NuggetsBySubarea
        {
            get
            {
                return nuggetsBySubarea;
            }

            set
            {
                nuggetsBySubarea = value;
            }
        }
    }
}