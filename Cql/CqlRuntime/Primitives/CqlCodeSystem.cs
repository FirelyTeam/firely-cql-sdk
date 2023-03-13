using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.CodeSystem)]
    public class CqlCodeSystem
    {
        public CqlCodeSystem(string? id, string? version)
        {
            this.id = id;
            this.version = version;
        }

        public string? id { get; set; }

        public string? version { get; set; }

    }
}
