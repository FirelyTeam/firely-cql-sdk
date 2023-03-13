using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Fhir.Schemas
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ChoiceTypeByNameAttribute: Attribute
    {
        public ChoiceTypeByNameAttribute(string TypeName)
        {
            this.TypeName = TypeName;
        }

        public string TypeName { get; }
    }
}
