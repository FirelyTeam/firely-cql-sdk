using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

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
            throw new NotImplementedException("Case expressions are not yet implemented.");
        }

        //  : 'when' expression 'then' expression;
        public override Expression VisitCaseExpressionItem([Antlr4.Runtime.Misc.NotNull] cqlParser.CaseExpressionItemContext context)
        {
            throw new NotImplementedException("Case expressions are not yet implemented.");
        }
    }
}
