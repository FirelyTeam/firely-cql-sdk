using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class RetrieveExpression : Expression
{
    public RetrieveExpression(TypeSymbol type, Expression? context, Expression? path,
        CodeComparator? comparator, Expression? terminology) : base(type)
    {
        Context = context;
        Path = path;
        Comparator = comparator;
        Terminology = terminology;
    }

    public Expression? Context { get; }

    public Expression? Path { get; }

    public CodeComparator? Comparator { get; }

    public Expression? Terminology { get; }
}

internal delegate IQueryable<object?> Retrieve(RetrieveExpression expression, IDictionary<Symbol, Expression>? symbols);

internal enum CodeComparator { Equal, Equivalent }
