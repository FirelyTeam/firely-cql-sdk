using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CqlLibraryAttribute: Attribute
    {
        public CqlLibraryAttribute(string Identifier, string Version)
        {
            this.Identifier = Identifier;
            this.Version = Version;
        }

        public string Identifier { get; }
        public string Version { get; }
    }
}
