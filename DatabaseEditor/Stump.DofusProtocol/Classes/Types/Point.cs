using System;
using Stump.DofusProtocol.Classes;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.D2oClasses
{
    [Serializable]
    [D2OClass("Point", "flash.geom")]
    public class Point : IDataObject
    {
        public int x;
        public int y;
        public double length;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
    }
}