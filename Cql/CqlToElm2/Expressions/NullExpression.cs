using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class NullExpression: Expression
{
    public NullExpression() : base(NullTypeSymbol.Default)
    {
    }

    /// <summary>
    /// Create a typed null.  Used when null is converted to another type.
    /// </summary>
    /// <param name="type"></param>
    public NullExpression(TypeSymbol type) : base(type)
    {
    }

}
