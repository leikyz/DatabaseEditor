// Generated on 06/05/2015 03:00:23

using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("MapScrollActions", "com.ankamagames.dofus.datacenter.world", true)]
    public class MapScrollAction : IDataObject, IIndexedData
    {
        public const string MODULE = "MapScrollActions";

        public bool bottomExists;

        public int bottomMapId;
        public int id;

        public bool leftExists;

        public int leftMapId;

        public bool rightExists;

        public int rightMapId;

        public bool topExists;

        public int topMapId;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public bool RightExists
        {
            get { return rightExists; }

            set { rightExists = value; }
        }

        [D2OIgnore]
        public bool BottomExists
        {
            get { return bottomExists; }

            set { bottomExists = value; }
        }

        [D2OIgnore]
        public bool LeftExists
        {
            get { return leftExists; }

            set { leftExists = value; }
        }

        [D2OIgnore]
        public bool TopExists
        {
            get { return topExists; }

            set { topExists = value; }
        }

        [D2OIgnore]
        public int RightMapId
        {
            get { return rightMapId; }

            set { rightMapId = value; }
        }

        [D2OIgnore]
        public int BottomMapId
        {
            get { return bottomMapId; }

            set { bottomMapId = value; }
        }

        [D2OIgnore]
        public int LeftMapId
        {
            get { return leftMapId; }

            set { leftMapId = value; }
        }

        [D2OIgnore]
        public int TopMapId
        {
            get { return topMapId; }

            set { topMapId = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}