// Generated on 06/05/2015 03:00:13

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Smileys", "com.ankamagames.dofus.datacenter.communication", true)]
    public class Smiley : IDataObject, IIndexedData
    {
        public const string MODULE = "Smileys";

        public bool forPlayers;

        public string gfxId;
        public int id;

        public uint order;

        public List<string> triggers;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public string GfxId
        {
            get { return gfxId; }

            set { gfxId = value; }
        }

        [D2OIgnore]
        public bool ForPlayers
        {
            get { return forPlayers; }

            set { forPlayers = value; }
        }

        [D2OIgnore]
        public List<string> Triggers
        {
            get { return triggers; }

            set { triggers = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}