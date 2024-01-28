﻿using System;

namespace Stump.DofusProtocol.Classes
{
    [Serializable]
    public class TransformData : IDataObject
    {
        public string originalClip;
        public string overrideClip;
        public double rotation = 0.0;
        public double scaleX = 1.0;
        public double scaleY = 1.0;
        public double x = 0.0;
        public double y = 0.0;
    }
}