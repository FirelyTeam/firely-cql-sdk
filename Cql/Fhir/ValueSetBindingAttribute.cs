using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Fhir
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
