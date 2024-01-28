using System;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2o
{
    public class D2OFieldAttribute : Attribute
    {
        public D2OFieldAttribute()
        {
        }

        public D2OFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        public string FieldName { get; set; }
    }
}