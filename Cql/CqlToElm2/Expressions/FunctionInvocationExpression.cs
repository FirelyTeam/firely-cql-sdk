using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class FunctionInvocationExpression: Expression
{
    public FunctionInvocationExpression(FunctionSymbol function,
        IList<ArgumentSymbol> arguments,
        TypeSymbol returnType): base(returnType)
    {
        Function = function;
        Arguments = arguments.AsReadOnly();
    }

    public FunctionSymbol Function { get; }
    public IReadOnlyList<ArgumentSymbol> Arguments { get; }

}
