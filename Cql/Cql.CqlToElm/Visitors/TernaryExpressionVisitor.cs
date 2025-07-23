/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;

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
