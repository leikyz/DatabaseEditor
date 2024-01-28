// Generated on 06/05/2015 03:00:19

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Monsters", "com.ankamagames.dofus.datacenter.monsters", true)]
    public class Monster : IDataObject, IIndexedData
    {
        public const string MODULE = "Monsters";

        public List<AnimFunMonsterData> animFunList;

        public bool canBePushed;

        public bool canPlay;

        public bool canSwitchPos;

        public bool canTackle;

        public uint correspondingMiniBossId;

        public int creatureBoneId;

        public List<MonsterDrop> drops;

        public bool fastAnimsFun;

        public int favoriteSubareaId;

        public uint gfxId;

        public List<MonsterGrade> grades;
        public int id;

        public List<uint> incompatibleIdols;

        public bool isBoss;

        public bool isMiniBoss;

        public bool isQuestMonster;

        public string look;

        public uint nameId;

        public int race;

        public float speedAdjust;

        public List<uint> spells;

        public List<uint> subareas;

        public bool useBombSlot;

        public bool useSummonSlot;

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
        public uint GfxId
        {
            get { return gfxId; }

            set { gfxId = value; }
        }

        [D2OIgnore]
        public int Race
        {
            get { return race; }

            set { race = value; }
        }

        [D2OIgnore]
        public List<MonsterGrade> Grades
        {
            get { return grades; }

            set { grades = value; }
        }

        [D2OIgnore]
        public string Look
        {
            get { return look; }

            set { look = value; }
        }

        [D2OIgnore]
        public bool UseSummonSlot
        {
            get { return useSummonSlot; }

            set { useSummonSlot = value; }
        }

        [D2OIgnore]
        public bool UseBombSlot
        {
            get { return useBombSlot; }

            set { useBombSlot = value; }
        }

        [D2OIgnore]
        public bool CanPlay
        {
            get { return canPlay; }

            set { canPlay = value; }
        }

        [D2OIgnore]
        public bool CanTackle
        {
            get { return canTackle; }

            set { canTackle = value; }
        }

        [D2OIgnore]
        public List<AnimFunMonsterData> AnimFunList
        {
            get { return animFunList; }

            set { animFunList = value; }
        }

        [D2OIgnore]
        public bool IsBoss
        {
            get { return isBoss; }

            set { isBoss = value; }
        }

        [D2OIgnore]
        public List<MonsterDrop> Drops
        {
            get { return drops; }

            set { drops = value; }
        }

        [D2OIgnore]
        public List<uint> Subareas
        {
            get { return subareas; }

            set { subareas = value; }
        }

        [D2OIgnore]
        public List<uint> Spells
        {
            get { return spells; }

            set { spells = value; }
        }

        [D2OIgnore]
        public int FavoriteSubareaId
        {
            get { return favoriteSubareaId; }

            set { favoriteSubareaId = value; }
        }

        [D2OIgnore]
        public bool IsMiniBoss
        {
            get { return isMiniBoss; }

            set { isMiniBoss = value; }
        }

        [D2OIgnore]
        public bool IsQuestMonster
        {
            get { return isQuestMonster; }

            set { isQuestMonster = value; }
        }

        [D2OIgnore]
        public uint CorrespondingMiniBossId
        {
            get { return correspondingMiniBossId; }

            set { correspondingMiniBossId = value; }
        }

        [D2OIgnore]
        public float SpeedAdjust
        {
            get { return speedAdjust; }

            set { speedAdjust = value; }
        }

        [D2OIgnore]
        public int CreatureBoneId
        {
            get { return creatureBoneId; }

            set { creatureBoneId = value; }
        }

        [D2OIgnore]
        public bool CanBePushed
        {
            get { return canBePushed; }

            set { canBePushed = value; }
        }

        [D2OIgnore]
        public bool FastAnimsFun
        {
            get { return fastAnimsFun; }

            set { fastAnimsFun = value; }
        }

        [D2OIgnore]
        public bool CanSwitchPos
        {
            get { return canSwitchPos; }

            set { canSwitchPos = value; }
        }

        [D2OIgnore]
        public List<uint> IncompatibleIdols
        {
            get { return incompatibleIdols; }

            set { incompatibleIdols = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}