// Generated on 06/05/2015 03:00:12

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("AlmanaxCalendars", "com.ankamagames.dofus.datacenter.almanax", true)]
    public class AlmanaxCalendar : IDataObject, IIndexedData
    {
        public const string MODULE = "AlmanaxCalendars";

        public uint descId;
        public int id;

        public uint nameId;

        public int npcId;

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
        public uint DescId
        {
            get { return descId; }

            set { descId = value; }
        }

        [D2OIgnore]
        public int NpcId
        {
            get { return npcId; }

            set { npcId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}