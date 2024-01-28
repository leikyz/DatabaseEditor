// Generated on 06/05/2015 03:00:19

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("ActionDescriptions", "com.ankamagames.dofus.datacenter.misc", true)]
    public class ActionDescription : IDataObject, IIndexedData
    {
        public const string MODULE = "ActionDescriptions";

        public uint descriptionId;
        public int id;

        public uint maxUsePerFrame;

        public uint minimalUseInterval;

        public string name;

        public bool needConfirmation;

        public bool needInteraction;

        public bool trusted;

        public uint typeId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        [D2OIgnore]
        public uint DescriptionId
        {
            get { return descriptionId; }

            set { descriptionId = value; }
        }

        [D2OIgnore]
        public bool Trusted
        {
            get { return trusted; }

            set { trusted = value; }
        }

        [D2OIgnore]
        public bool NeedInteraction
        {
            get { return needInteraction; }

            set { needInteraction = value; }
        }

        [D2OIgnore]
        public uint MaxUsePerFrame
        {
            get { return maxUsePerFrame; }

            set { maxUsePerFrame = value; }
        }

        [D2OIgnore]
        public uint MinimalUseInterval
        {
            get { return minimalUseInterval; }

            set { minimalUseInterval = value; }
        }

        [D2OIgnore]
        public bool NeedConfirmation
        {
            get { return needConfirmation; }

            set { needConfirmation = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}