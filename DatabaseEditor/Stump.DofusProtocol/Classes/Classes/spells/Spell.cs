// Generated on 06/05/2015 03:00:22

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Spells", "com.ankamagames.dofus.datacenter.spells", true)]
    public class Spell : IDataObject, IIndexedData
    {
        public const string MODULE = "Spells";

        public uint descriptionId;

        public int iconId;
        public int id;

        public uint nameId;

        public int scriptId;

        public int scriptIdCritical;

        public string scriptParams;

        public string scriptParamsCritical;

        public List<uint> spellLevels;

        public uint typeId;

        public bool useParamCache = true;

        public bool verbose_cast;

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
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public string ScriptParams
        {
            get { return scriptParams; }

            set { scriptParams = value; }
        }

        [D2OIgnore]
        public string ScriptParamsCritical
        {
            get { return scriptParamsCritical; }

            set { scriptParamsCritical = value; }
        }

        [D2OIgnore]
        public int ScriptId
        {
            get { return scriptId; }

            set { scriptId = value; }
        }

        [D2OIgnore]
        public int ScriptIdCritical
        {
            get { return scriptIdCritical; }

            set { scriptIdCritical = value; }
        }

        [D2OIgnore]
        public int IconId
        {
            get { return iconId; }

            set { iconId = value; }
        }

        [D2OIgnore]
        public List<uint> SpellLevels
        {
            get { return spellLevels; }

            set { spellLevels = value; }
        }

        [D2OIgnore]
        public bool UseParamCache
        {
            get { return useParamCache; }

            set { useParamCache = value; }
        }

        [D2OIgnore]
        public bool Verbose_cast
        {
            get { return verbose_cast; }

            set { verbose_cast = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }

        public int Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }
    }
}