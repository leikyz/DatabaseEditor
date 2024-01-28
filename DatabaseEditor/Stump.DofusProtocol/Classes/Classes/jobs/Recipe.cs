// Generated on 06/05/2015 03:00:18

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Recipes", "com.ankamagames.dofus.datacenter.jobs")]
    public class Recipe : IDataObject, IIndexedData
    {
        public const string MODULE = "Recipes";

        public List<int> ingredientIds;

        public int jobId;

        public List<uint> quantities;
        public uint resultId;

        public uint resultLevel;

        public uint resultNameId;

        public uint resultTypeId;

        public int skillId;

        [D2OIgnore]
        public uint ResultId
        {
            get { return resultId; }

            set { resultId = value; }
        }

        [D2OIgnore]
        public uint ResultNameId
        {
            get { return resultNameId; }

            set { resultNameId = value; }
        }

        [D2OIgnore]
        public uint ResultTypeId
        {
            get { return resultTypeId; }

            set { resultTypeId = value; }
        }

        [D2OIgnore]
        public uint ResultLevel
        {
            get { return resultLevel; }

            set { resultLevel = value; }
        }

        [D2OIgnore]
        public List<int> IngredientIds
        {
            get { return ingredientIds; }

            set { ingredientIds = value; }
        }

        [D2OIgnore]
        public List<uint> Quantities
        {
            get { return quantities; }

            set { quantities = value; }
        }

        [D2OIgnore]
        public int JobId
        {
            get { return jobId; }

            set { jobId = value; }
        }

        [D2OIgnore]
        public int SkillId
        {
            get { return skillId; }

            set { skillId = value; }
        }

        int IIndexedData.Id => (int) resultId;
    }
}