// Generated on 06/05/2015 03:00:15

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Interactives", "com.ankamagames.dofus.datacenter.interactives", true)]
    public class Interactive : IDataObject, IIndexedData
    {
        public const string MODULE = "Interactives";

        public int actionId;

        public bool displayTooltip;
        public int id;

        public uint nameId;

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
        public int ActionId
        {
            get { return actionId; }

            set { actionId = value; }
        }

        [D2OIgnore]
        public bool DisplayTooltip
        {
            get { return displayTooltip; }

            set { displayTooltip = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}