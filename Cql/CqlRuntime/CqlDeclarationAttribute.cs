using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class CqlDeclarationAttribute: Attribute
    {

        public CqlDeclarationAttribute(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; }
    }
}
