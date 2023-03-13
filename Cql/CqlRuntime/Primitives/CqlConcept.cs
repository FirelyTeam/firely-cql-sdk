using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Concept)]
    public class CqlConcept
    {
        public CqlCode[]? codes { get; }
        public string? display { get; }

        public CqlConcept(IEnumerable<CqlCode> codes, string? display)
        {
            if (codes == null)
                this.codes = new CqlCode[0];
            else 
                this.codes = codes.ToArray();
            this.display = display;
        }

    }
}
