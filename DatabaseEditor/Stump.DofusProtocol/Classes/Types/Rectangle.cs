using Stump.DofusProtocol.D2oClasses;
using System;

namespace Stump.DofusProtocol.Classes
{
    [Serializable]
    public class Rectangle : IDataObject
    {
        public int bottom;
        public Point bottomRight;
        public int height;
        public int left;
        public int right;
        public Point size;
        public int top;
        public Point topLeft;
        public int width;
        public int x;
        public int y;
    }
}