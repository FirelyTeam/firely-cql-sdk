using System;

namespace Hl7.Cql.Poco.Fhir.Schemas
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
