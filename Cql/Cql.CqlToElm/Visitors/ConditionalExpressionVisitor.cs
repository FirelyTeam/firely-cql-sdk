using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
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

            var @if = ElmFactory.If(condition, then, @else);
            return @if
                .WithId()
                .WithLocator(context.Locator());
        }

        //     | 'case' expression? caseExpressionItem+ 'else' expression 'end'                #caseExpressionTerm
        // TODO: refactor case terms into the InvocationBuilder?
        public override Expression VisitCaseExpressionTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.CaseExpressionTermContext context)
        {
            var expressions = context.expression();
            Expression? comparand = null;
            Expression @else;
            if (expressions.Length == 2)
            {
                comparand = Visit(expressions[0]);
                @else = Visit(expressions[1]);
            }
            else if (expressions.Length == 1)
            {
                @else = Visit(expressions[0]);
            }
            else
            {
                return new Case()
                    .AddError($"Case statements should contain 1 or 2 expressions, not {expressions.Length}")
                    .WithId()
                    .WithLocator(context.Locator());
            }
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
                        var caseItem = new CaseItem();

                        var when = Visit(item.expression(0));
                        var whenCastResult = CoercionProvider.Coerce(when, comparand?.resultTypeSpecifier ?? SystemTypes.BooleanType);
                        if (whenCastResult.Success)
                            caseItem.when = whenCastResult.Result;
                        else if (whenCastResult.Error is not null)
                            caseItem.AddError(whenCastResult.Error);

                        caseItem.then = Visit(item.expression(1));

                        return caseItem
                            .WithResultType(caseItem.then.resultTypeSpecifier)
                            .WithLocator(context.Locator());
                    }
                })
                .ToArray();

            var resultTypes = new HashSet<TypeSpecifier>(caseItems
                .Select(item => item.then.resultTypeSpecifier)
                .Append(@else.resultTypeSpecifier))
                .Except(new[] { SystemTypes.AnyType })
                .ToList();
            TypeSpecifier returnType;
            if (resultTypes.Count == 0)
                returnType = SystemTypes.AnyType;
            if (resultTypes.Count == 1)
                returnType = resultTypes.Single();
            else
                returnType = new ChoiceTypeSpecifier(resultTypes);
            foreach (var item in caseItems)
            {
                var then = item.then;
                var thenCastResult = CoercionProvider.Coerce(then, returnType);
                if (thenCastResult.Success)
                {
                    item.then = thenCastResult.Result;
                    item.resultTypeSpecifier = item.then.resultTypeSpecifier;
                }
                else if (thenCastResult.Error is not null)
                    item.AddError(thenCastResult.Error);
            }
            var elseCastResult = CoercionProvider.Coerce(@else, returnType);
            if (elseCastResult.Success)
                @else = elseCastResult.Result;
            else if (elseCastResult.Error is not null)
                @else.AddError(elseCastResult.Error);

            return ElmFactory.Case(comparand, caseItems, @else)
                .WithId()
                .WithLocator(context.Locator());
        }
    }
}
