using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.ValueSet)]
    public class CqlValueSet
    {
        public CqlValueSet(string? id, string? version)
        {
            this.id = id;
            this.version = version;
        }

        public string? id { get; }
        public string? version { get; }

    }
}
