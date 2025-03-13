using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;

[DebuggerDisplay("{Value}")]
internal class LiteralExpression : Expression
{
    public LiteralExpression(object? value, TypeSymbol type) : base(type)
    {
        Value = value;
    }

    public object? Value { get; }

}
