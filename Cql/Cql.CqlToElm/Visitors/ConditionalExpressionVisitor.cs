using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        // | 'if' expression 'then' expression 'else' expression                           #ifThenElseExpressionTerm
        public override Expression VisitIfThenElseExpressionTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.IfThenElseExpressionTermContext context)
        {
            var condition = Visit(context.expression(0));
            var then = Visit(context.expression(1));
            var @else = Visit(context.expression(2));

            return SystemLibrary.If.Call(InvocationBuilder, context, condition, then, @else);
        }

        //     | 'case' expression? caseExpressionItem+ 'else' expression 'end'                #caseExpressionTerm
        public override Expression VisitCaseExpressionTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.CaseExpressionTermContext context)
        {
            var expressions = context.expression();
            if (expressions.Length != 1)
            {
                var @case = (Case)SystemLibrary.Case.CreateElmNode();
                return @case.AddError("Expecting expression for else case");
            }
            var @else = Visit(expressions[0]);

            var caseItems = context.caseExpressionItem()
                .Select(item =>
                {
                    var itemExpressions = item.expression();
                    if (itemExpressions.Length != 2)
                    {
                        var @caseItem = new CaseItem();
                        return @caseItem
                            .AddError("Case item should have two expressions: one for the when clause, and one for the then clause.");
                    }
                    else
                    {
                        var when = Visit(item.expression(0));
                        var then = Visit(item.expression(1));
                        return SystemLibrary.CaseItem.Call(InvocationBuilder, context, when, then);
                    }
                })
                .ToArray();
            return SystemLibrary.Case.Call(InvocationBuilder, context, caseItems, @else);
        }
    }
}
