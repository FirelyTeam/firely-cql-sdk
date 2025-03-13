using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
/// <summary>
/// A symbol that binds an operand to an expression.  This is similar to an <see cref="ExpressionSymbol"/>, but is used
/// in conjunction with <see cref="FunctionInvocationExpression"/> to represent the arguments to a function.
/// </summary>
internal class ArgumentSymbol: Symbol
{
    public ArgumentSymbol(OperandSymbol operand, Expression expression) : base(operand.Name)
    {
        Operand = operand;
        Expression = expression;
    }

    public OperandSymbol Operand { get; }
    public Expression Expression { get; }

    public override AccessModifier AccessModifier => AccessModifier.Public;

    public override TypeSymbol Type => Operand.Type;

    public override SymbolType SymbolType => SymbolType.Argument;
}
