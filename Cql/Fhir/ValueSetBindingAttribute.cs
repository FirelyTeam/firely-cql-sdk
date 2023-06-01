using System;

namespace Hl7.Cql.Poco.Fhir
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ValueSetBindingAttribute : Attribute
    {
        public ValueSetBindingAttribute(string Name, string Url, bool IsRequired)
        {
            this.Name = Name;
            this.Url = Url;
            this.IsRequired = IsRequired;
        }

        public string Name { get; }
        public string Url { get; }
        public bool IsRequired { get; }
    }
}
