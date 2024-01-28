// Generated on 06/05/2015 03:00:20

using System.Collections.Generic;
using Stump.DofusProtocol.D2oClasses;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("QuestObjectives", "com.ankamagames.dofus.datacenter.quest", true)]
    public class QuestObjective : IDataObject, IIndexedData
    {
        public const string MODULE = "QuestObjectives";

        public Point coords;

        public int dialogId;
        public int id;

        public int mapId;

        public List<uint> parameters;

        public uint stepId;

        public QuestObjectiveType type;

        public uint typeId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint StepId
        {
            get { return stepId; }

            set { stepId = value; }
        }

        [D2OIgnore]
        public uint TypeId
        {
            get { return typeId; }

            set { typeId = value; }
        }

        [D2OIgnore]
        public int DialogId
        {
            get { return dialogId; }

            set { dialogId = value; }
        }

        [D2OIgnore]
        public List<uint> Parameters
        {
            get { return parameters; }

            set { parameters = value; }
        }

        [D2OIgnore]
        public Point Coords
        {
            get { return coords; }

            set { coords = value; }
        }

        [D2OIgnore]
        public int MapId
        {
            get { return mapId; }

            set { mapId = value; }
        }

        [D2OIgnore]
        public QuestObjectiveType Type
        {
            get { return type; }

            set { type = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}