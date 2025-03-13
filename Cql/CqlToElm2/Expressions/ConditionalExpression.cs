using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class ConditionalExpression : Expression
{
    public ConditionalExpression(Case[] cases, Expression @else): base(@else.Type)
    {
        if (cases.Any(c=>c.Then.Type != @else.Type))
            throw new ArgumentException("All cases must have the same type as the else expression");
        Cases = cases;
        Else = @else;
    }

    public Case[] Cases { get; }
    public Expression Else { get; }

}

internal record Case(Expression When, Expression Then);
