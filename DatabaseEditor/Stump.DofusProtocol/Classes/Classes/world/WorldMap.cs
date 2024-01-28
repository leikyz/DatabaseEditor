// Generated on 06/05/2015 03:00:23

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("WorldMaps", "com.ankamagames.dofus.datacenter.world", true)]
    public class WorldMap : IDataObject, IIndexedData
    {
        public const string MODULE = "WorldMaps";

        public int centerX;

        public int centerY;

        public uint horizontalChunck;
        public int id;

        public float mapHeight;

        public float mapWidth;

        public float maxScale;

        public float minScale;

        public uint nameId;

        public int origineX;

        public int origineY;

        public float startScale;

        public int totalHeight;

        public int totalWidth;

        public uint verticalChunck;

        public bool viewableEverywhere;

        public List<string> zoom;

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
        public int OrigineX
        {
            get { return origineX; }

            set { origineX = value; }
        }

        [D2OIgnore]
        public int OrigineY
        {
            get { return origineY; }

            set { origineY = value; }
        }

        [D2OIgnore]
        public float MapWidth
        {
            get { return mapWidth; }

            set { mapWidth = value; }
        }

        [D2OIgnore]
        public float MapHeight
        {
            get { return mapHeight; }

            set { mapHeight = value; }
        }

        [D2OIgnore]
        public uint HorizontalChunck
        {
            get { return horizontalChunck; }

            set { horizontalChunck = value; }
        }

        [D2OIgnore]
        public uint VerticalChunck
        {
            get { return verticalChunck; }

            set { verticalChunck = value; }
        }

        [D2OIgnore]
        public bool ViewableEverywhere
        {
            get { return viewableEverywhere; }

            set { viewableEverywhere = value; }
        }

        [D2OIgnore]
        public float MinScale
        {
            get { return minScale; }

            set { minScale = value; }
        }

        [D2OIgnore]
        public float MaxScale
        {
            get { return maxScale; }

            set { maxScale = value; }
        }

        [D2OIgnore]
        public float StartScale
        {
            get { return startScale; }

            set { startScale = value; }
        }

        [D2OIgnore]
        public int CenterX
        {
            get { return centerX; }

            set { centerX = value; }
        }

        [D2OIgnore]
        public int CenterY
        {
            get { return centerY; }

            set { centerY = value; }
        }

        [D2OIgnore]
        public int TotalWidth
        {
            get { return totalWidth; }

            set { totalWidth = value; }
        }

        [D2OIgnore]
        public int TotalHeight
        {
            get { return totalHeight; }

            set { totalHeight = value; }
        }

        [D2OIgnore]
        public List<string> Zoom
        {
            get { return zoom; }

            set { zoom = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}