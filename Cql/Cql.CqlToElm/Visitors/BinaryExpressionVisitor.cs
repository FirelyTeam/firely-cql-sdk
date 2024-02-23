using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        //   expression 'and' expression                                                                   #andExpression
        public override Expression VisitAndExpression([NotNull] cqlParser.AndExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            var and = InvocationBuilder.Invoke(SystemLibrary.And, lhs, rhs);
            return and
                .WithId()
                .WithLocator(context.Locator());
        }

        // expressionTerm('+' | '-' | '&') expressionTerm                               #additionExpressionTerm
        public override Expression VisitAdditionExpressionTerm([NotNull] cqlParser.AdditionExpressionTermContext context)
        {
            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(terms[1]);

            var invocation = @operator switch
            {
                "+"  => InvocationBuilder.Invoke(SystemLibrary.Add, lhs, rhs),
                "-" => InvocationBuilder.Invoke(SystemLibrary.Subtract, lhs, rhs),
                "&" => InvocationBuilder.Invoke(SystemLibrary.Concatenate, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in addition expression."),
            };
            return invocation
                .WithId()
                .WithLocator(context.Locator());
        }

        //    | 'difference' 'in' pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm       #differenceBetweenExpression
        public override Expression VisitDifferenceBetweenExpression([NotNull] cqlParser.DifferenceBetweenExpressionContext context) =>
            VisitBinaryWithPrecision(SystemLibrary.DifferenceBetween, context, context.pluralDateTimePrecision(), context.expressionTerm());

        //     | ('duration' 'in')? pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm      #durationBetweenExpression
        public override Expression VisitDurationBetweenExpression([NotNull] cqlParser.DurationBetweenExpressionContext context) =>
            VisitBinaryWithPrecision(SystemLibrary.DurationBetween, context, context.pluralDateTimePrecision(), context.expressionTerm());


        // | expression ('=' | '!=' | '~' | '!~') expression                                               #equalityExpression
        public override Expression VisitEqualityExpression([NotNull] cqlParser.EqualityExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressions[1]);

            var expression = @operator switch
            {
                "=" => InvocationBuilder.Invoke(SystemLibrary.Equal, lhs, rhs),
                "!=" => InvocationBuilder.Invoke(SystemLibrary.NotEqual, lhs, rhs),
                "~" => InvocationBuilder.Invoke(SystemLibrary.Equivalent, lhs, rhs),
                "!~" => NotEquivalent(lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in equality expression.")
            };
            return expression
                .WithId()
                .WithLocator(context.Locator());

            Expression NotEquivalent(Expression lhs, Expression rhs)
            {
                var equivalent = InvocationBuilder.Invoke(SystemLibrary.Equivalent, lhs, rhs);
                var not = InvocationBuilder.Invoke(SystemLibrary.Not, equivalent);
                return not;
            }
        }

        //  expression 'implies' expression                                                               #impliesExpression
        public override Expression VisitImpliesExpression([NotNull] cqlParser.ImpliesExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            return InvocationBuilder.Invoke(SystemLibrary.Implies, lhs, rhs)
                .WithId()
                .WithLocator(context.Locator());
        }

        //    | expression ('<=' | '<' | '>' | '>=') expression                                               #inequalityExpression
        public override Expression VisitInequalityExpression([NotNull] cqlParser.InequalityExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressions[1]);

            Expression result = @operator switch
            {
                ">" => InvocationBuilder.Invoke(SystemLibrary.Greater, lhs, rhs),
                ">=" => InvocationBuilder.Invoke(SystemLibrary.GreaterOrEqual, lhs, rhs),
                "<" => InvocationBuilder.Invoke(SystemLibrary.Less, lhs, rhs),
                "<=" => InvocationBuilder.Invoke(SystemLibrary.LessOrEqual, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in inequality expression."),
            };

            return result
                .WithId()
                .WithLocator(context.Locator());
        }

        // | expressionTerm ('*' | '/' | 'div' | 'mod') expressionTerm                     #multiplicationExpressionTerm
        public override Expression VisitMultiplicationExpressionTerm([NotNull] cqlParser.MultiplicationExpressionTermContext context)
        {
            var expressionTerms = context.expressionTerm();
            var lhs = Visit(expressionTerms[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressionTerms[1]);

            var expression = @operator switch
            {
                "*" => InvocationBuilder.Invoke(SystemLibrary.Multiply, lhs, rhs),
                "/" => InvocationBuilder.Invoke(SystemLibrary.Divide, lhs, rhs),
                "div" => InvocationBuilder.Invoke(SystemLibrary.TruncatedDivide, lhs, rhs),
                "mod" => InvocationBuilder.Invoke(SystemLibrary.Modulo, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in multiplication expression.")
            };
            return expression
                .WithId()
                .WithLocator(context.Locator());

        }

        //     | expression ('or' | 'xor') expression                                                          #orExpression
        public override Expression VisitOrExpression([NotNull] cqlParser.OrExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1)!.GetText();
            var rhs = Visit(expressions[1]);

            Expression result = @operator switch
            {
                "or" => InvocationBuilder.Invoke(SystemLibrary.Or, lhs, rhs),
                "xor" => InvocationBuilder.Invoke(SystemLibrary.Xor, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in (x)or expression.")
            };

            return result
                .WithId()
                .WithLocator(context.Locator());
        }

        //| expressionTerm '^' expressionTerm                                             #powerExpressionTerm
        public override Expression VisitPowerExpressionTerm([NotNull] cqlParser.PowerExpressionTermContext context)
        {
            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var rhs = Visit(terms[1]);

            return InvocationBuilder.Invoke(SystemLibrary.Power, lhs, rhs)
                .WithId()
                .WithLocator(context.Locator());
        }

        public override Expression VisitIndexedExpressionTerm([NotNull] cqlParser.IndexedExpressionTermContext context)
        {
            var term = Visit(context.expressionTerm());
            var index = Visit(context.expression());
            var indexer = new Indexer
            {
                operand = new[] { term, index }
            };
            TypeSpecifier type;
            if (term.resultTypeSpecifier is ListTypeSpecifier listType)
                type = listType.elementType;
            else if (term.resultTypeSpecifier is NamedTypeSpecifier namedType)
            {
                if (namedType == SystemTypes.StringType)
                    type = SystemTypes.StringType;
                else
                {
                    indexer.AddError($"Unable to index type {namedType.name}");
                    type = SystemTypes.AnyType;
                }
            }
            else
            {
                indexer.AddError($"Unable to index type {term.resultTypeSpecifier}");
                type = SystemTypes.AnyType;
            }
            return indexer
                .WithLocator(context.Locator())
                .WithResultType(type);
        }





    }
}
