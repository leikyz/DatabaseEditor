// Generated on 06/05/2015 03:00:13

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Emoticons", "com.ankamagames.dofus.datacenter.communication", true)]
    public class Emoticon : IDataObject, IIndexedData
    {
        public const string MODULE = "Emoticons";

        public List<string> anims;

        public bool aura;

        public uint cooldown = 1000;

        public string defaultAnim;

        public uint duration;

        public bool eight_directions;
        public int id;

        public uint nameId;

        public uint order;

        public bool persistancy;

        public uint shortcutId;

        public uint weight;

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
        public uint ShortcutId
        {
            get { return shortcutId; }

            set { shortcutId = value; }
        }

        [D2OIgnore]
        public uint Order
        {
            get { return order; }

            set { order = value; }
        }

        [D2OIgnore]
        public string DefaultAnim
        {
            get { return defaultAnim; }

            set { defaultAnim = value; }
        }

        [D2OIgnore]
        public bool Persistancy
        {
            get { return persistancy; }

            set { persistancy = value; }
        }

        [D2OIgnore]
        public bool Eight_directions
        {
            get { return eight_directions; }

            set { eight_directions = value; }
        }

        [D2OIgnore]
        public bool Aura
        {
            get { return aura; }

            set { aura = value; }
        }

        [D2OIgnore]
        public List<string> Anims
        {
            get { return anims; }

            set { anims = value; }
        }

        [D2OIgnore]
        public uint Cooldown
        {
            get { return cooldown; }

            set { cooldown = value; }
        }

        [D2OIgnore]
        public uint Duration
        {
            get { return duration; }

            set { duration = value; }
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
    }
}