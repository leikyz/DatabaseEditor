// Generated on 06/05/2015 03:00:19

using System;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("CensoredContents", "com.ankamagames.dofus.datacenter.misc", true)]
    public class CensoredContent : IDataObject, IIndexedData
    {
        public const string MODULE = "CensoredContents";

        public string lang;

        public int newValue;

        public int oldValue;
        public int type;

        [D2OIgnore]
        public int Type
        {
            get { return type; }

            set { type = value; }
        }

        [D2OIgnore]
        public int OldValue
        {
            get { return oldValue; }

            set { oldValue = value; }
        }

        [D2OIgnore]
        public int NewValue
        {
            get { return newValue; }

            set { newValue = value; }
        }

        [D2OIgnore]
        public string Lang
        {
            get { return lang; }

            set { lang = value; }
        }


        public int Id
        {
            get { throw new NotImplementedException(); }
        }
    }
}