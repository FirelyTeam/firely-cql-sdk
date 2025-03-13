using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
/// <summary>
/// 
/// </summary>
internal class ExpressionSymbol : Symbol
{
    public ExpressionSymbol(string name, AccessModifier accessModifier, Expression expression) : base(name)
    {
        AccessModifier = accessModifier;
        Expression = expression;
        Type = expression.Type;
    }

    public override AccessModifier AccessModifier { get; }

    public override TypeSymbol Type { get; }

    public override SymbolType SymbolType => SymbolType.Expression;

    public Expression Expression { get; }

}
