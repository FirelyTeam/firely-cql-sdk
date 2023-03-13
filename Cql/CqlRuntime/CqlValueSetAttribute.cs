using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class CqlValueSetAttribute: Attribute
    {

        public CqlValueSetAttribute(string Id)
        {
            this.Id = Id;
        }
        public string Id { get; }
    }
}
