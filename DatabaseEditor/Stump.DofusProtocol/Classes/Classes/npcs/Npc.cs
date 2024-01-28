// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Npcs", "com.ankamagames.dofus.datacenter.npcs", true)]
    public class Npc : IDataObject, IIndexedData
    {
        public const string MODULE = "Npcs";

        public List<uint> actions;

        public List<AnimFunNpcData> animFunList;

        public List<List<int>> dialogMessages;

        public List<List<int>> dialogReplies;

        public bool fastAnimsFun;

        public uint gender;
        public int id;

        public string look;

        public uint nameId;

        public int tokenShop;

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
        public List<List<int>> DialogMessages
        {
            get { return dialogMessages; }

            set { dialogMessages = value; }
        }

        [D2OIgnore]
        public List<List<int>> DialogReplies
        {
            get { return dialogReplies; }

            set { dialogReplies = value; }
        }

        [D2OIgnore]
        public List<uint> Actions
        {
            get { return actions; }

            set { actions = value; }
        }

        [D2OIgnore]
        public uint Gender
        {
            get { return gender; }

            set { gender = value; }
        }

        [D2OIgnore]
        public string Look
        {
            get { return look; }

            set { look = value; }
        }

        [D2OIgnore]
        public int TokenShop
        {
            get { return tokenShop; }

            set { tokenShop = value; }
        }

        [D2OIgnore]
        public List<AnimFunNpcData> AnimFunList
        {
            get { return animFunList; }

            set { animFunList = value; }
        }

        [D2OIgnore]
        public bool FastAnimsFun
        {
            get { return fastAnimsFun; }

            set { fastAnimsFun = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}