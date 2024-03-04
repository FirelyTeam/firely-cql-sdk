using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        //  expression 'properly'? 'between' expressionTerm 'and' expressionTerm 
        public override Expression VisitBetweenExpression([NotNull] cqlParser.BetweenExpressionContext context)
        {
            var operand = Visit(context.expression());
            var et = context.expressionTerm();
            var floor = Visit(et[0]);
            var ceiling = Visit(et[1]);
            bool proper = false;
            if (context.GetChild(1).GetText() == "properly")
                proper = true;

            Expression expression;
            if (proper)
                expression = InvocationBuilder.Invoke(SystemLibrary.ProperBetween, operand, floor, ceiling);
            else
                expression = InvocationBuilder.Invoke(SystemLibrary.Between, operand, floor, ceiling);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

    }
}
