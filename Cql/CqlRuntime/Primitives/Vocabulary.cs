using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Vocabulary)]
    public class Vocabulary
    {
        public Vocabulary(string? id, string? version)
        {
            this.id = id;
            this.version = version;
        }

        public string? id { get; }

        public string? version { get;  }

    }
}
